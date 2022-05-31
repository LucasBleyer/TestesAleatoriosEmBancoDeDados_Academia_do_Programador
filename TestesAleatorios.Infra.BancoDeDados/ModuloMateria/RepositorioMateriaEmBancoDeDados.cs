using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesAleatorios.Dominio.Compartilhado;
using TestesAleatorios.Dominio.ModuloMateria;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace TestesAleatorios.Infra.BancoDeDados.ModuloMateria
{
    public class RepositorioMateriaEmBancoDeDados : IRepositorioMateria
    {
        private const string enderecoBanco = "Data Source=(LocalDB)\\MSSqlLocalDB;Initial Catalog=TestesDB;Integrated Security=True;Pooling=False";

        #region Sql Queries
        private const string sqlInserir =
            @"INSERT INTO [TBDISCIPLINA] 
                (
                    [NOME],
                    [SERIE]
	            )
	            VALUES
                (
                    @NOME,
                    @SERIE
                );SELECT SCOPE_IDENTITY();";

        private const string sqlEditar =
            @"UPDATE [TBMATERIA]	
		        SET
			        [NOME] = @NOME,
                    [SERIE] = @SERIE
		        WHERE
			        [NUMERO] = @NUMERO";

        private const string sqlExcluir =
            @"DELETE FROM [TBMATERIA]
		        WHERE
			        [NUMERO] = @NUMERO";

        private const string sqlSelecionarTodos =
            @"SELECT 
		            [NUMERO],
                    [NOME],
                    [SERIE],
                    [NUMERO_DISCIPLINA]
	            FROM 
		            [TBMATERIA]";

        private const string sqlSelecionarPorNumero =
            @"SELECT 
		            [NUMERO],
                    [NOME],
                    [SERIE],
                    [NUMERO_DISCIPLINA]
	            FROM 
		            [TBMATERIA]
		        WHERE
                    [NUMERO] = @NUMERO";
        #endregion

        FluentValidation.Results.ValidationResult IRepositorioMateria.Inserir(Materia novaMateria)
        {
            var validador = new ValidadorMateria();

            var resultadoValidacao = validador.Validate(novaMateria);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            ConfigurarParametrosMateria(novaMateria, comandoInsercao);

            conexaoComBanco.Open();

            var id = comandoInsercao.ExecuteScalar();
            //utilizado para executar instruções SQL como count, sum, min, esse método retorna apenas um valor como resultado

            novaMateria.Numero = Convert.ToInt32(id);

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        FluentValidation.Results.ValidationResult IRepositorioMateria.Editar(Materia materia)
        {
            var validador = new ValidadorMateria();

            var resultadoValidacao = validador.Validate(materia);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexaoComBanco);

            ConfigurarParametrosMateria(materia, comandoEdicao);

            conexaoComBanco.Open();

            comandoEdicao.ExecuteNonQuery();
            //é utilizado para executar instruções SQL que não retornam dados
            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        FluentValidation.Results.ValidationResult IRepositorio<Materia>.Excluir(Materia registro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexaoComBanco);

            comandoExclusao.Parameters.AddWithValue("NUMERO", registro.Numero);

            conexaoComBanco.Open();

            int numeroRegistrosExcluidos = comandoExclusao.ExecuteNonQuery();
            //é utilizado para executar instruções SQL que não retornam dados

            var resultadoValidacao = new ValidationResult();

            if (numeroRegistrosExcluidos == 0)
                resultadoValidacao.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro"));

            conexaoComBanco.Close();

            return resultadoValidacao;
        }

        public List<Materia> SelecionarTodos()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);

            conexaoComBanco.Open();

            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();
            //método utilizado para execultar uma instrução SQL que retorna um DataReader

            List<Materia> materias = new List<Materia>();

            while (leitorMateria.Read())
            {
                Materia materia = ConverterParaMateria(leitorMateria);

                materias.Add(materia);
            }

            conexaoComBanco.Close();

            return materias;
        }

        public Materia SelecionarPorNumero(int numero)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorNumero, conexaoComBanco);

            comandoSelecao.Parameters.AddWithValue("NUMERO", numero);

            conexaoComBanco.Open();
            SqlDataReader leitorMateria = comandoSelecao.ExecuteReader();
            //método utilizao para execultar uma instrução SQL que retorna um DataReader

            Materia materia = null;
            if (leitorMateria.Read())
                materia = ConverterParaMateria(leitorMateria);

            conexaoComBanco.Close();

            return materia;
        }

        private static Materia ConverterParaMateria(SqlDataReader leitorMateria)
        {
            int numero = Convert.ToInt32(leitorMateria["NUMERO"]);
            string nome = Convert.ToString(leitorMateria["NOME"]);
            int serie = Convert.ToInt32(leitorMateria["SERIE"]);

            var materia = new Materia
            {
                Numero = numero,
                Nome = nome,
                Serie = serie.ToString()
            };

            return materia;
        }

        private static void ConfigurarParametrosMateria(Materia novaMateria, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("NUMERO", novaMateria.Numero);
            comando.Parameters.AddWithValue("NOME", novaMateria.Nome);
            comando.Parameters.AddWithValue("SERIE", novaMateria.Serie);
        }
    }
}
