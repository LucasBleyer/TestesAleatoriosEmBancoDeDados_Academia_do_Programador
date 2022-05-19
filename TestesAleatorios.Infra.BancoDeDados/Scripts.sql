--Criando a tabela de Contatos
	CREATE TABLE [dbo].[TBDisciplina] (
		[Numero]   INT           IDENTITY (1, 1) NOT NULL,
		[Nome]     VARCHAR (300) NOT NULL,
		PRIMARY KEY CLUSTERED ([Numero] ASC)
	);


--Inserindo um registro na tabela
	INSERT INTO [TBDISCIPLINA] 
	(
		[NOME]
	)
	VALUES 
	(
		'História'
	); 


--Acessando toda a tabela de disciplina
	select * from [TBDisciplina]

--Atualizando um registro da tabela
	--UPDATE [TBCONTATO]	
	--	SET
	--		[NOME] = 'RODRIGO CAIO',
	--		[EMAIL] = 'XERIFE@MENGAO.COM',
	--		[TELEFONE] = '987654321',
	--		[EMPRESA] = 'FLAMENGO',
	--		[CARGO] = 'ZAGUEIRO'
	--	WHERE
	--		[NUMERO] = 2

--Excluindo um registro da tabela
	--DELETE FROM [TBCONTATO]
	--	WHERE 
	--		[NUMERO] = 4

--Retornando todos os registros da tabela
	--SELECT 
	--	[NUMERO], 
	--	[NOME], 
	--	[EMAIL],
	--	[TELEFONE],
	--	[EMPRESA],
	--	[CARGO]
	--FROM 
	--	[TBCONTATO]

--Retornando apenas um registro da tabela 
--	SELECT 
--		[NUMERO], 
--		[NOME], 
--		[EMAIL],
--		[TELEFONE],
--		[EMPRESA],
--		[CARGO]
--	FROM 
--		[TBCONTATO]
--	WHERE 
--		[NUMERO] = 1

--select count(*) from TBContato