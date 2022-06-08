--create database cartaoBD

--use cartaoBD
--go

--create table nivel_academico
--(
--	id int primary key identity(1,1) not null,
--	nivel int default(1)
--)
--insert into nivel_academico(nivel) values(1)
--insert into nivel_academico(nivel) values (2)
--insert into nivel_academico(nivel) values (3)
--insert into nivel_academico(nivel) values (4)
--insert into nivel_academico(nivel) values (5)

--create table faculdade
--(
--	id_faculdade int primary key identity(1,1) not null,
--	nome_faculdade varchar(max) not null,
--	sigla varchar(10) not null
--)
--insert into faculdade(nome_faculdade, sigla) values('Gestão e Ciências Económicas','FGCE')
--insert into faculdade(nome_faculdade, sigla) values('Letras e Ciências Sociais','FLCS')
--insert into faculdade(nome_faculdade, sigla) values('Engenharias','FE')


--create table curso
--(
--	id int primary key identity(1,1) not null,
--	curso varchar(300) unique not null,
--	id_faculdade int references faculdade(id_faculdade)
--)
----Cursos da Faculdade de Gestão e Ciências Económicas
--insert into curso(curso, id_faculdade) values('Gestão', 1)
--insert into curso(curso, id_faculdade) values('Contabilidade e Finanças', 1)

----Cursos da Faculdade de Letras e Ciências Sociais
--insert into curso(curso, id_faculdade) values('Relações Internacionais', 2)
--insert into curso(curso, id_faculdade) values('Psicologia', 2)
--insert into curso(curso, id_faculdade) values('Lígua e Literatura Inglesa', 2)
--insert into curso(curso, id_faculdade) values('Direito', 2)

----Cursos da Faculdade de engenharia
--insert into curso(curso, id_faculdade) values('Geologia', 3)
--insert into curso(curso, id_faculdade) values('Engenharia de Minas', 3)
--insert into curso(curso, id_faculdade) values('Arquitetura e Urbanismo', 3)
--insert into curso(curso, id_faculdade) values('Telecomunicações e Electrônica', 3)
--insert into curso(curso, id_faculdade) values('Geologia e Minas', 3)
--insert into curso(curso, id_faculdade) values('Engenharia Civil', 3)
--insert into curso(curso, id_faculdade) values('Engenharia do Ambiente', 3)
--insert into curso(curso, id_faculdade) values('Engenharia Informática', 3)

--create table Aluno
--(
--	BI varchar(20) primary key not null,
--	aluno_nome varchar(300) not null,
--	datanascimento date not null,

--	aluno_tlfn varchar(15) unique not null,
--	aluno_email varchar(300) unique,

--	n_Matricula int unique not null,
--	id_curso int references curso(id) not null,
--	nivel_acad int references nivel_academico(id) not null
--)

--create table cartao
--(
--	card_id int primary key identity(1,3) not null,
--	aluno varchar(20) references Aluno(BI) unique not null,
--	data_emissao date not null,
--	data_validade date not null,
--	foto_aluno image,
--)





----- PROCEDIMENTOS -----


--CREATE PROC CriarCartao
--	@BI varchar(20),
--	@dataE varchar(100),
--	@dataV varchar(100),
--	@foto varbinary(max)
--AS
--BEGIN
--	SET NOCOUNT ON;
	
--	INSERT INTO cartao (aluno, data_emissao,data_validade, foto_aluno)
--	VALUES
--	(@BI, @dataE, @dataV, @foto);
--END

--CREATE PROC Via2Cartao
--@cardID int,
--@dataE date,
--@dataV date
--AS
--BEGIN
--	update cartao set data_emissao=@dataE, data_validade=@dataV WHERE card_id=@cardID
--END


--CREATE PROC TodosCursos
--AS
--BEGIN
--	select
--	curso.id, curso.curso
--	from curso ORDER BY curso asc
--END

--CREATE PROC AlunoComCartao
--AS
--BEGIN
--	select
--	Aluno.aluno_nome, Aluno.BI, Aluno.n_Matricula,
--	curso.curso, nivel_academico.nivel,
--	cartao.card_id
--	from Aluno inner join curso on Aluno.id_curso=curso.id
--	right join cartao on Aluno.BI = cartao.aluno
--	inner join nivel_academico on Aluno.nivel_acad=nivel_academico.id
--END

--CREATE PROC PesquisaComCartao
--@palavraChave varchar(max)
--AS
--BEGIN
--	select
--	Aluno.aluno_nome, Aluno.BI, Aluno.n_Matricula,
--	curso.curso, nivel_academico.nivel,
--	cartao.card_id
--	from Aluno inner join curso on Aluno.id_curso=curso.id
--	right join cartao on Aluno.BI = cartao.aluno
--	inner join nivel_academico on Aluno.nivel_acad=nivel_academico.id
--	Where Aluno.aluno_nome = @palavraChave OR Aluno.BI= @palavraChave
--END

--CREATE PROC AdicionaAluno
--	@nome varchar(300),
--	@BI varchar(20),
--	@data date,
--	@telefone varchar(15),
--	@email varchar(300),
--	@curso int,
--	@nivel int
--AS
--BEGIN
--Declare @nMatricula varchar(10);
--	if (Select MAX(n_Matricula) from Aluno) is null
--		Begin
--			Select @nMatricula = 1
--		end
--	else
--		begin
--			Select @nMatricula = MAX(n_Matricula) + 1 from Aluno 
--		end
--	INSERT INTO Aluno (aluno_nome, BI, datanascimento, aluno_tlfn, aluno_email, n_Matricula, id_curso, nivel_acad)
--	VALUES
--	(@nome, @BI, @data, @telefone, @email, @nMatricula, @curso, @nivel);
--END


--CREATE PROC AlunoSemCartao
--AS
--BEGIN
--	select
--	Aluno.aluno_nome, Aluno.BI, Aluno.n_Matricula,
--	curso.curso, nivel_academico.nivel,
--	cartao.card_id
--	from Aluno inner join curso on Aluno.id_curso=curso.id
--	left outer join cartao on Aluno.BI = cartao.aluno
--	inner join nivel_academico on Aluno.nivel_acad=nivel_academico.id
--	where cartao.card_id is null
--END

--CREATE PROC PesquisaSemCartao
--@palavraChave varchar(max)
--AS
--BEGIN
--	select
--	Aluno.aluno_nome, Aluno.BI, Aluno.n_Matricula,
--	curso.curso, nivel_academico.nivel,
--	cartao.card_id
--	from Aluno inner join curso on Aluno.id_curso=curso.id
--	left outer join cartao on Aluno.BI = cartao.aluno
--	inner join nivel_academico on Aluno.nivel_acad=nivel_academico.id
--	Where Aluno.aluno_nome = @palavraChave AND cartao.card_id is null OR Aluno.BI= @palavraChave AND cartao.card_id is null
--END

--create procedure PesquisarCartao
--@id int
--as
--begin
--	select
--	Aluno.aluno_nome, Aluno.n_Matricula,
--	curso.curso,
--	cartao.data_emissao, cartao.data_validade, cartao.foto_aluno
--	from cartao
--	inner join Aluno on cartao.aluno=Aluno.BI
--	inner join curso on curso.id=Aluno.id_curso
--	Where cartao.card_id=@id
--end

--CREATE PROCEDURE TotalCartoes
--AS
--BEGIN
--	select COUNT(card_id)as 'Resultado' from cartao
--END

------ FUNCAO PARA CALCULAR A VALIDADE DO CARTAO

--CREATE FUNCTION validade(@DataValidade DATETIME)
--RETURNS INT
--AS 
--BEGIN
--  RETURN DATEDIFF(DAY, GETDATE(), @DataValidade)
--END


--create procedure cartaoValido
--as
--BEGIN
--	declare @tempo date
--declare @qtd int
--select @qtd = 0
--Declare cursorTeste Cursor
--for SELECT cartao.data_validade from cartao
----abrir
--open cursorTeste
----Selecionar valor
--Fetch next from cursorTeste
--into @tempo
----iteracao
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	Fetch next from cursorTeste
--	into @tempo
--	if (select dbo.validade(@tempo)) > 1
--	BEGIN
--		Select @qtd = @qtd + 1
--	END
--END
--select @qtd as 'Cartões Validos'
----fechando e deslocando
--close cursorTeste
--deallocate cursorTeste
--END


--create procedure cartaoInvalido
--as
--BEGIN
--	declare @tempo date
--declare @qtd int
--select @qtd = 0
--Declare cursorTeste Cursor
--for SELECT cartao.data_validade from cartao
----abrir
--open cursorTeste
----Selecionar valor
--Fetch next from cursorTeste
--into @tempo
----iteracao
--WHILE @@FETCH_STATUS = 0
--BEGIN
--	Fetch next from cursorTeste
--	into @tempo
--	if (select dbo.validade(@tempo)) <= 0
--	BEGIN
--		Select @qtd = @qtd + 1
--	END
--END
--select @qtd as 'Cartões Invalidos'
----fechando e deslocando
--close cursorTeste
--deallocate cursorTeste
--END

--CREATE PROC TotalSemCartao
--AS
--BEGIN
--	select
--	COUNT(*) as 'Resultado'
--	from Aluno inner join curso on Aluno.id_curso=curso.id
--	left outer join cartao on Aluno.BI = cartao.aluno
--	inner join nivel_academico on Aluno.nivel_acad=nivel_academico.id
--	where cartao.card_id is null
--END