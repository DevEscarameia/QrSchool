using app;
using app.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

internal class Banco
{

    private static SQLiteConnection conexao;

    //Faz a conexão a Db

    // Função para estabelecer a conexão com o banco de dados SQLite
    private static SQLiteConnection ConexaoBanco()
    {
        // Verifica se a variável 'conexao' já foi inicializada, ou seja, se já há uma conexão aberta.
        if (conexao == null)
        {
            // Obtém o caminho para a pasta "AppData" do sistema operacional, onde será armazenado o banco de dados.
            string pastaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // Define o caminho completo para o banco de dados SQLite (dentro de "QRSchool" em "AppData").
            string caminhoBanco = Path.Combine(pastaAppData, "QRSchool", "db_escola");

            // Verifica se a pasta "QRSchool" já existe no diretório "AppData". Caso contrário, cria a pasta.
            if (!Directory.Exists(Path.Combine(pastaAppData, "QRSchool")))
            {
                Directory.CreateDirectory(Path.Combine(pastaAppData, "QRSchool"));
            }

            // Cria uma nova conexão SQLite com o caminho do banco de dados definido acima.
            conexao = new SQLiteConnection($"Data Source={caminhoBanco};Version=3;");

            // Abre a conexão com o banco de dados.
            conexao.Open();
        }

        // Retorna a conexão estabelecida (caso já tenha sido criada) ou a nova conexão.
        return conexao;
    }



    public static DataTable ObterTodosUtilizadores()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_utilizadores";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //função para ir buscar os dados dos cartões
    public static DataTable ObterCartões()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDCARTAO as 'ID', T_NOME as 'Nome', N_NUMERO as 'Número' FROM tb_cartoes";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static DataTable TodosCartões()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_cartoes";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //função para adicionar novos alunos a tabela tb_cartoes
    public static void CriarAluno(Alunos aluno)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_cartoes(T_NOME, N_NUMERO, N_TRIENIO, T_CURSO, I_FTALUNO, I_QRCODE, I_CARTAO) VALUES(@T_NOME, @N_NUMERO, @N_TRIENIO, @T_CURSO, @I_FTALUNO, @I_QRCODE, @I_CARTAO)";
                cmd.Parameters.AddWithValue("@T_NOME", aluno.T_NOME);
                cmd.Parameters.AddWithValue("@N_NUMERO", aluno.N_NUMERO);
                cmd.Parameters.AddWithValue("@N_TRIENIO", aluno.N_TRIENIO);
                cmd.Parameters.AddWithValue("@T_CURSO", aluno.T_CURSO);
                cmd.Parameters.AddWithValue("@I_FTALUNO", aluno.I_FTALUNO);
                cmd.Parameters.AddWithValue("@I_QRCODE", aluno.I_QRCODE);
                cmd.Parameters.AddWithValue("@I_CARTAO", aluno.I_CARTAO);
                cmd.ExecuteNonQuery();
                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao criar utilizador: " + ex.Message);
            ConexaoBanco().Close();
        }
    }

    // função para fazer a consulta
    public static DataTable consulta(string sql)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //função para adicionar novos utilizadores
    public static void NovoUtilizador(Utilizador utilizador)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_utilizadores(T_NOMEUTILIZADOR, T_SENHAUTILIZADOR, N_NIVELUTILIZADOR, I_FTUTILIZADOR) VALUES(@T_NOMEUTILIZADOR, @T_SENHAUTILIZADOR, @N_NIVELUTILIZADOR, @I_FTUTILIZADOR)";
                cmd.Parameters.AddWithValue("@T_NOMEUTILIZADOR", utilizador.T_NOMEUTILIZADOR);
                cmd.Parameters.AddWithValue("@T_SENHAUTILIZADOR", utilizador.T_SENHAUTILIZADOR);
                cmd.Parameters.AddWithValue("@N_NIVELUTILIZADOR", utilizador.N_NIVELUTILIZADOR);
                cmd.Parameters.AddWithValue("@I_FTUTILIZADOR", utilizador.I_FTUTILIZADOR);
                cmd.ExecuteNonQuery();

                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Este utilizador já existe!");
            ConexaoBanco().Close();
        }
    }
    public static DataTable TodosUtilizadores()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDUTILIZADOR as 'ID', T_NOMEUTILIZADOR as 'Nome Utilizador', N_NIVELUTILIZADOR as 'Nível' FROM tb_utilizadores";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    //função para ir buscaros dados id e nome da tabela dos utilizadores 

    public static DataTable UtilizadoresIdNome()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDUTILIZADOR as 'ID', T_NOMEUTILIZADOR as 'Nome Utilizador' FROM tb_utilizadores";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //função para atualizar os utilizadores
    public static void AtualizarUtilizador(Utilizador u)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = "UPDATE tb_utilizadores SET T_NOMEUTILIZADOR=@Nome, T_SENHAUTILIZADOR=@Senha, N_NIVELUTILIZADOR=@Nivel, I_FTUTILIZADOR=@Imagem WHERE N_IDUTILIZADOR=@ID";
                cmd.Parameters.AddWithValue("@Nome", u.T_NOMEUTILIZADOR);
                cmd.Parameters.AddWithValue("@Senha", u.T_SENHAUTILIZADOR);
                cmd.Parameters.AddWithValue("@Nivel", u.N_NIVELUTILIZADOR);
                cmd.Parameters.AddWithValue("@Imagem", u.I_FTUTILIZADOR); // Aqui estamos passando os bytes da imagem
                cmd.Parameters.AddWithValue("@ID", u.N_IDUTILIZADOR);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    //função para apagar o utilizador
    public static void ApagarUtilizador(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_utilizadores WHERE N_IDUTILIZADOR=" + id;
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }
    }
    public static void ApagarAluno(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_cartoes WHERE N_IDCARTAO=" + id;
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }
    }
    //funçao para obter os dados dos professores 
    public static DataTable ObterProfessores()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT T_NOMEPROFESSOR FROM tb_professores";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static DataTable ObterTodosProfessores()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDPROFESSOR AS ID, T_NOMEPROFESSOR AS Professor FROM tb_professores";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


    //função para adicionar requisições 
    public static void NovaRequisição(Requisições requisições)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_requisiçõesComputadores(T_PROFESSORRESPONSAVEL, T_TURMA, T_HORAINICIO,T_HORAFIM, N_NºPORTATEIS, T_DATAREQUISIÇÃO, T_DESCRIÇAO) VALUES(@T_PROFESSORRESPONSAVEL, @T_TURMA, @T_HORAINICIO,@T_HORAFIM, @N_NºPORTATEIS, @T_DATAREQUISIÇÃO, @T_DESCRIÇAO)";
                cmd.Parameters.AddWithValue("@T_PROFESSORRESPONSAVEL", requisições.T_PROFESSORRESPONSAVEL);
                cmd.Parameters.AddWithValue("@T_TURMA", requisições.T_TURMA);
                cmd.Parameters.AddWithValue("@T_HORAINICIO", requisições.T_HORAINICIO);
                cmd.Parameters.AddWithValue("@T_HORAFIM", requisições.T_HORAFIM);
                cmd.Parameters.AddWithValue("@N_NºPORTATEIS", requisições.N_NºPORTATEIS);
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", requisições.T_DATAREQUISIÇÃO.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@T_DESCRIÇAO", requisições.T_DESCRIÇAO);
                cmd.ExecuteNonQuery();

                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao fazer requisição: " + ex.Message);
            ConexaoBanco().Close();
        }
    }
    public static void AtualizarRequisições(Requisições requisições)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "UPDATE tb_requisiçõesComputadores SET T_PROFESSORRESPONSAVEL=@T_PROFESSORRESPONSAVEL, T_TURMA=@T_TURMA, T_HORAINICIO=@T_HORAINICIO,T_HORAFIM=@T_HORAFIM , N_NºPORTATEIS=@N_NºPORTATEIS, T_DATAREQUISIÇÃO=@T_DATAREQUISIÇÃO WHERE N_IDREQUISIÇÃO=@N_IDREQUISIÇÃO";
                cmd.Parameters.AddWithValue("@T_PROFESSORRESPONSAVEL", requisições.T_PROFESSORRESPONSAVEL);
                cmd.Parameters.AddWithValue("@T_TURMA", requisições.T_TURMA);
                cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃO", requisições.N_IDREQUISIÇÃO);
                cmd.Parameters.AddWithValue("@T_HORAINICIO", requisições.T_HORAINICIO);
                cmd.Parameters.AddWithValue("@T_HORAFIM", requisições.T_HORAFIM);
                cmd.Parameters.AddWithValue("@N_NºPORTATEIS", requisições.N_NºPORTATEIS);
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", requisições.T_DATAREQUISIÇÃO.ToString("yyyy-MM-dd"));
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable TodasRequisições()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDREQUISIÇÃO as ID, T_PROFESSORRESPONSAVEL as Professor, T_TURMA as Turma, " +
                  "strftime('%H:%M', T_HORAINICIO) as Inicio, " +
                  "strftime('%H:%M', T_HORAFIM) as Fim, " +
                  "N_NºPORTATEIS as Portateis, T_DATAREQUISIÇÃO as Data " +
                  "FROM tb_requisiçõesComputadores " +
                  "WHERE T_DATAREQUISIÇÃO >= date('now', 'localtime')";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable TodasRequisiçõesFeitas(Levantamentos levantamentos)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                // A consulta está correta para filtrar pelo ID da requisição
                cmd.CommandText = "SELECT N_IDREQUISIÇÃOFEITA AS 'Id', " +
                  "N_IDREQUISIÇÃO AS 'ID Reserva', " +
                  "N_IDALUNO AS 'Aluno', " +
                  "N_IDPORTATIL AS 'Portátil', " +
                  "T_PROFESSOR AS 'Professor', " +
                  "N_HORALEVANTAMENTO AS 'Hora de Levantamento', " +
                  "D_DATALEVANTAMENTO AS 'Data de Levantamento', " +
                  "T_STATUS AS 'Estado'" +
                  "FROM tb_Levantamentos " +
                  "WHERE N_IDREQUISIÇÃO = @ID_Requisição";

                cmd.Parameters.AddWithValue("@ID_Requisição", levantamentos.N_IDREQUISIÇÃO);

                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt); // Preenche o DataTable com os resultados da consulta
            }

            return dt;
        }
        catch (Exception ex)
        {
            // É mais seguro usar 'throw' para manter a pilha de chamadas original
            throw new Exception("Erro ao carregar as requisições.", ex);
        }
    }

    public static void NovoLevantamento(Levantamentos levantamento)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_Levantamentos (N_IDREQUISIÇÃO, N_IDALUNO, N_IDPORTATIL, T_PROFESSOR, N_HORALEVANTAMENTO, D_DATALEVANTAMENTO, T_STATUS) " +
                               "VALUES (@N_IDREQUISIÇÃO, @N_IDALUNO, @N_IDPORTATIL, @T_PROFESSOR, @N_HORALEVANTAMENTO, @D_DATALEVANTAMENTO, @T_STATUS )";

                cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃO", levantamento.N_IDREQUISIÇÃO);
                cmd.Parameters.AddWithValue("@N_IDALUNO", levantamento.N_IDALUNO);
                cmd.Parameters.AddWithValue("@N_IDPORTATIL", levantamento.N_IDPORTATIL);
                cmd.Parameters.AddWithValue("@T_PROFESSOR", levantamento.T_PROFESSOR);
                cmd.Parameters.AddWithValue("@N_HORALEVANTAMENTO", DateTime.Now.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@D_DATALEVANTAMENTO", DateTime.Now.Date.ToString("yyyy-MM-dd")); // Data atual do levantamento
                cmd.Parameters.AddWithValue("@T_STATUS", levantamento.T_STATUS);
                cmd.ExecuteNonQuery();
                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao fazer requisição: " + ex.Message);
            ConexaoBanco().Close();
        }
    }
    public static void ApagarRequisição(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_requisiçõesComputadores WHERE N_IDREQUISIÇÃO = @N_IDREQUISIÇÃO";
                cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃO", id);
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }
    }
    public static void ApagarHistorico(string data1, string data2)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_requisiçõesComputadores WHERE T_DATAREQUISIÇÃO >= @data1 AND T_DATAREQUISIÇÃO <= @data2";
                cmd.Parameters.AddWithValue("@data1", data1);
                cmd.Parameters.AddWithValue("@data2", data2);
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }
    }

    public static int ContarRequisicoesPorHora(DateTime horaRequisicao)
    {
        int numeroRequisicoes = 0;

        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                // Use a função strftime para obter apenas a hora da data e comparar com a hora de requisição
                cmd.CommandText = "SELECT COUNT(*) FROM tb_requisiçõesComputadores WHERE strftime('%H:%M', T_DATAREQUISIÇÃO) = strftime('%H:%M', @HoraRequisicao)";
                cmd.Parameters.AddWithValue("@HoraRequisicao", horaRequisicao.ToString("HH:mm"));

                numeroRequisicoes = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch (Exception ex)
        {
            // Trate a exceção conforme necessário
            MessageBox.Show("Erro ao contar requisições por hora: " + ex.Message);
        }

        return numeroRequisicoes;
    }

    public static int ObterQuantidadeLevantamentos(int idRequisiçao)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM tb_Levantamentos WHERE N_IDREQUISIÇÃO = @idRequisiçao";
                cmd.Parameters.AddWithValue("@idRequisiçao", idRequisiçao);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao contar Levantamentos: " + ex.Message);
            return 0;
        }
        finally
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }

    public static DataTable ObterReservas(string turma = null, string data = null, string hora = null, string professor = null)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_requisiçõesComputadores WHERE 1 = 1";

                if (!string.IsNullOrEmpty(turma))
                {
                    cmd.CommandText += " AND T_TURMA = @Turma";
                    cmd.Parameters.AddWithValue("@Turma", turma);
                }

                if (!string.IsNullOrEmpty(data))
                {
                    cmd.CommandText += " AND T_DATAREQUISIÇÃO = @Data";
                    cmd.Parameters.AddWithValue("@Data", data);
                }

                if (!string.IsNullOrEmpty(hora))
                {
                    cmd.CommandText += " AND T_HORARIO = @Hora";
                    cmd.Parameters.AddWithValue("@Hora", hora);
                }

                if (!string.IsNullOrEmpty(professor))
                {
                    cmd.CommandText += " AND T_PROFESSORRESPONSAVEL = @Professor";
                    cmd.Parameters.AddWithValue("@Professor", professor);
                }

                var dataTable = new DataTable();
                using (var reader = cmd.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                return dataTable;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }
    }
    public static DataTable TodosComputadores()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT ID_Portateis AS ID,T_SOFTWARES AS Softwares, T_DESCRIÇÃO AS Descrição, B_ESTADO AS Estado  FROM tb_portateis";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static DataTable TodosComputadoresSelecionar()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT ID_Portateis AS ID,T_SOFTWARES AS Softwares, T_DESCRIÇÃO AS Descrição  FROM tb_portateis";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void AtualizarComputadores(Computador c)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = "UPDATE tb_portateis SET T_SOFTWARES=@T_SOFTWARES, T_DESCRIÇÃO=@T_DESCRIÇÃO, B_ESTADO=@B_ESTADO WHERE ID_Portateis=@ID_Portateis";
                cmd.Parameters.AddWithValue("@T_SOFTWARES", c.T_SOFTWARES);
                cmd.Parameters.AddWithValue("@ID_Portateis", c.ID_Portateis);
                cmd.Parameters.AddWithValue("@T_DESCRIÇÃO", c.T_DESCRIÇÃO);
                cmd.Parameters.AddWithValue("@B_ESTADO", c.B_ESTADO);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
   
    public static void NovoComputador(Computador c)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_portateis(T_SOFTWARES,T_DESCRIÇÃO,B_ESTADO) VALUES(@T_SOFTWARES,@T_DESCRIÇÃO,@B_ESTADO)";
                cmd.Parameters.AddWithValue("@T_SOFTWARES", c.T_SOFTWARES);
                cmd.Parameters.AddWithValue("@T_DESCRIÇÃO", c.T_DESCRIÇÃO);
                cmd.Parameters.AddWithValue("@B_ESTADO", c.B_ESTADO);
                cmd.ExecuteNonQuery();

                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao criar Professor: " + ex.Message);
            ConexaoBanco().Close();
        }
    }
    public static void ApagarComputador(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_portateis WHERE ID_Portateis =" + id;
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }

    }
    public static DataTable ObterHorarioInicio()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT T_HORAINICIO FROM tb_horarios ";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable ObterHorarioFim()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT T_HORAFIM FROM tb_horarios";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    } 
    public static DataTable ObterReservasPorHorario(DateTime dataReserva, string horaInicio, string horaFim)
    {

        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                string dataFormatada = dataReserva.ToString("yyyy-MM-dd");

                cmd.CommandText = "SELECT SUM(N_NºPORTATEIS) as TotalPortateis FROM tb_requisiçõesComputadores WHERE T_DATAREQUISIÇÃO = @T_DATAREQUISIÇÃO  AND T_HORAINICIO >= @T_HORAINICIO  AND T_HORAFIM <= @T_HORAFIM;";

                // Adicionar parâmetros
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", dataFormatada);
                cmd.Parameters.AddWithValue("@T_HORAINICIO", horaInicio);
                cmd.Parameters.AddWithValue("@T_HORAFIM", horaFim);

                // Passar o comando correto para o adaptador
                da = new SQLiteDataAdapter(cmd);

                // Preencher a DataTable com os resultados
                da.Fill(dt);
            }

            // Fechar a conexão após o uso
            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas por horário: " + ex.Message);
        }
    }

    public static DataTable ObterNumeroPortateis()
    {

        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "Select count(*) as NºDisponiveis From tb_portateis where B_Estado = 1;";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    public static int ContarLevantamentos(int idRequisicao)
    {
        int numeroLevantamentos = 0;

        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) as Numero FROM tb_Levantamentos WHERE N_IDREQUISIÇÃO = @ID_Requisicao;";

                cmd.Parameters.AddWithValue("@ID_Requisicao", idRequisicao);

                numeroLevantamentos = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }

        return numeroLevantamentos;
    }
    public static int ContarEntregas(int idRequisicao)
    {
        int numeroLevantamentos = 0;

        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) as Numero FROM tb_Entregas WHERE N_IDREQUISIÇÃO = @ID_Requisicao;";

                cmd.Parameters.AddWithValue("@ID_Requisicao", idRequisicao);

                numeroLevantamentos = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }

        return numeroLevantamentos;
    }
    public static void ApagarLevantamento(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_Levantamentos WHERE N_IDREQUISIÇÃOFEITA = @N_IDREQUISIÇÃOFEITA";
                cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃOFEITA", id);
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }
    }
    public static void ApagarEntrega(string id, string hora, string data, string professor)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                // Primeiro, obtemos os dados do levantamento para atualizar o status
                cmd.CommandText = "SELECT N_IDALUNO, N_IDPORTATIL, N_IDREQUISIÇÃO FROM tb_Entregas WHERE N_IDENTREGA = @N_IDENTREGA";
                cmd.Parameters.AddWithValue("@N_IDENTREGA", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Obtém os dados necessários para atualizar o status do levantamento
                        int idAluno = reader.GetInt32(0);  // N_IDALUNO
                        int idPortatil = reader.GetInt32(1); // N_IDPORTATIL
                        int idRequisicao = reader.GetInt32(2); // N_IDREQUISIÇÃO

                        // Agora apagamos a entrega
                        reader.Close(); // Fecha o reader antes de executar a exclusão
                        cmd.CommandText = @"DELETE FROM tb_Entregas 
                                    WHERE N_HORAENTREGA = @hora 
                                      AND D_DATAENTREGA = @data 
                                      AND T_PROFESSOR = @professor 
                                      AND N_IDALUNO = @aluno 
                                      AND N_IDPORTATIL = @portatil";
                        cmd.Parameters.AddWithValue("@hora", hora);
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@professor", professor.Trim());
                        cmd.Parameters.AddWithValue("@aluno", idAluno);
                        cmd.Parameters.AddWithValue("@portatil", idPortatil);
                        cmd.ExecuteNonQuery();

                        // Atualiza o status do levantamento para "Levantado"
                        cmd.CommandText = "UPDATE tb_Levantamentos SET T_STATUS = 'Levantado' " +
                                          "WHERE N_IDALUNO = @N_IDALUNO AND N_IDPORTATIL = @N_IDPORTATIL AND T_PROFESSOR = @professor   AND D_DATALEVANTAMENTO = @data  ";
                        cmd.Parameters.Clear(); // Limpar os parâmetros antigos
                        cmd.Parameters.AddWithValue("@data", data);
                        cmd.Parameters.AddWithValue("@professor", professor.Trim());
                        cmd.Parameters.AddWithValue("@N_IDALUNO", idAluno);
                        cmd.Parameters.AddWithValue("@N_IDPORTATIL", idPortatil);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao apagar entrega: " + ex.Message);
        }
        finally
        {
            conexao.Close();
        }
    }


    public static string VerificarLevantamentoExistente(int idRequisicao, int idAluno, int idPortatil)
    {
        try
        {
            conexao.Open();

            using (var cmd = conexao.CreateCommand())
            {
                // Verifica se o aluno já fez um levantamento nesta requisição
                cmd.CommandText = "SELECT COUNT(*) FROM tb_Levantamentos WHERE N_IDREQUISIÇÃO = @idRequisicao AND N_IDALUNO = @idAluno";
                cmd.Parameters.AddWithValue("@idRequisicao", idRequisicao);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);

                int countAluno = Convert.ToInt32(cmd.ExecuteScalar());

                if (countAluno > 0)
                {
                    return "Este aluno já fez um levantamento nesta requisição.";
                }

                // Limpa os parâmetros para a próxima verificação
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRequisicao", idRequisicao);
                cmd.Parameters.AddWithValue("@idPortatil", idPortatil);

                // Verifica se o portátil já foi levantado nesta requisição
                cmd.CommandText = "SELECT COUNT(*) FROM tb_Levantamentos WHERE N_IDREQUISIÇÃO = @idRequisicao AND N_IDPORTATIL = @idPortatil";
                int countPortatil = Convert.ToInt32(cmd.ExecuteScalar());

                if (countPortatil > 0)
                {
                    return "Este portátil já foi levantado nesta requisição. Escolha outro portátil.";
                }
            }

            // Retorna string vazia se não houver duplicações
            return "";
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao verificar levantamento existente: " + ex.Message);
            return "Erro inesperado ao verificar levantamento.";
        }
        finally
        {
            conexao.Close();
        }
    }
    public static string VerificarEntregaExistente(int idRequisicao, int idAluno, int idPortatil)
    {
        try
        {
            conexao.Open();

            using (var cmd = conexao.CreateCommand())
            {
                // Verifica se o aluno já fez um levantamento nesta requisição
                cmd.CommandText = "SELECT COUNT(*) FROM tb_Entregas WHERE N_IDREQUISIÇÃO = @idRequisicao AND N_IDALUNO = @idAluno";
                cmd.Parameters.AddWithValue("@idRequisicao", idRequisicao);
                cmd.Parameters.AddWithValue("@idAluno", idAluno);

                int countAluno = Convert.ToInt32(cmd.ExecuteScalar());

                if (countAluno > 0)
                {
                    return "Este aluno já entregou nesta requisição.";
                }

                // Limpa os parâmetros para a próxima verificação
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRequisicao", idRequisicao);
                cmd.Parameters.AddWithValue("@idPortatil", idPortatil);

                // Verifica se o portátil já foi levantado nesta requisição
                cmd.CommandText = "SELECT COUNT(*) FROM tb_Entregas WHERE N_IDREQUISIÇÃO = @idRequisicao AND N_IDPORTATIL = @idPortatil";
                int countPortatil = Convert.ToInt32(cmd.ExecuteScalar());

                if (countPortatil > 0)
                {
                    return "Este portátil já foi entregue nesta requisição. Escolha outro portátil.";
                }
            }

            // Retorna string vazia se não houver duplicações
            return "";
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao verificar entregas existente: " + ex.Message);
            return "Erro inesperado ao entregar levantamento.";
        }
        finally
        {
            conexao.Close();
        }
    }
    public static DataTable TodasRequisiçoesEntregues(Levantamentos levantamentos)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                // A consulta está correta para filtrar pelo ID da requisição
                cmd.CommandText = "SELECT N_IDENTREGA AS 'Id', " +
                  "N_IDREQUISIÇÃO AS 'ID Reserva', " +
                  "N_IDALUNO AS 'Aluno', " +
                  "N_IDPORTATIL AS 'Portátil', " +
                  "T_PROFESSOR AS 'Professor', " +
                  "N_HORAENTREGA AS 'Hora de Entrega', " +
                  "D_DATAENTREGA AS 'Data de Entrega', " +
                  "T_STATUS AS 'Estado'" +
                  "FROM tb_Entregas " +
                  "WHERE N_IDREQUISIÇÃO = @ID_Requisição";

                cmd.Parameters.AddWithValue("@ID_Requisição", levantamentos.N_IDREQUISIÇÃO);

                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt); // Preenche o DataTable com os resultados da consulta
            }

            return dt;
        }
        catch (Exception ex)
        {
            // É mais seguro usar 'throw' para manter a pilha de chamadas original
            throw new Exception("Erro ao carregar as requisições.", ex);
        }
    }
    public static void NovaEntrega(Entrega entrega)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                // Inserir nova entrega na tabela tb_Entregas
                cmd.CommandText = "INSERT INTO tb_Entregas (N_IDREQUISIÇÃO, N_IDALUNO, N_IDPORTATIL, T_PROFESSOR, N_HORAENTREGA, D_DATAENTREGA, T_STATUS) " +
                                "VALUES (@N_IDREQUISIÇÃO, @N_IDALUNO, @N_IDPORTATIL, @T_PROFESSOR, @N_HORAENTREGA, @D_DATAENTREGA, @T_STATUS)";

                cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃO", entrega.N_IDREQUISIÇÃO);
                cmd.Parameters.AddWithValue("@N_IDALUNO", entrega.N_IDALUNO);
                cmd.Parameters.AddWithValue("@N_IDPORTATIL", entrega.N_IDPORTATIL);
                cmd.Parameters.AddWithValue("@T_PROFESSOR", entrega.T_PROFESSOR);
                cmd.Parameters.AddWithValue("@N_HORAENTREGA", DateTime.Now.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@D_DATAENTREGA", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@T_STATUS", entrega.T_STATUS);
                cmd.ExecuteNonQuery();

                // Agora, atualizar o status do levantamento para "Entregue"
                cmd.CommandText = "UPDATE tb_Levantamentos SET T_STATUS = 'Entregue' " +
                                  "WHERE N_IDALUNO = @N_IDALUNO AND N_IDPORTATIL = @N_IDPORTATIL AND N_IDREQUISIÇÃO = @N_IDREQUISIÇÃO";
                cmd.ExecuteNonQuery();

                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao fazer Entrega: " + ex.Message);
            ConexaoBanco().Close();
        }
    }

    public static bool VerificarLevantamento(int idRequisicao, int idAluno, int idPortatil) { 
   
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM tb_Levantamentos " +
                              "WHERE N_IDREQUISIÇÃO = @N_IDREQUISIÇÃO " +
                              "AND N_IDALUNO = @N_IDALUNO " +
                              "AND N_IDPORTATIL = @N_IDPORTATIL";

                cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃO", idRequisicao);
                cmd.Parameters.AddWithValue("@N_IDALUNO", idAluno);
                cmd.Parameters.AddWithValue("@N_IDPORTATIL", idPortatil);

                Console.WriteLine($"VerificarLevantamento -> idRequisicao: {idRequisicao}, idAluno: {idAluno}, idPortatil: {idPortatil}");

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine($"Registos encontrados: {count}");

                return count > 0;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }

        
    }
    public static DataTable ObterHistorico()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDREQUISIÇÃO AS ID ,T_PROFESSORRESPONSAVEL as Professor, T_TURMA as Turma, " +
                  "strftime('%H:%M', T_HORAINICIO) as Inicio, " +
                  "strftime('%H:%M', T_HORAFIM) as Fim, " +
                  "N_NºPORTATEIS as Portateis, T_DATAREQUISIÇÃO as Data " +
                  "FROM tb_requisiçõesComputadores " +
                  "WHERE T_DATAREQUISIÇÃO <= date('now', 'localtime')";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void ApagarLevantamentoEspecifico(string hora, string data, string professor, string idAluno, string idPortatil)
    {
        try
        {
            conexao.Open();
            using (var transacao = conexao.BeginTransaction())
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.Transaction = transacao;

                    // Apagar todas as entregas associadas ao levantamento
                    cmd.CommandText = @"DELETE FROM tb_Entregas 
                                    WHERE N_IDALUNO = @aluno 
                                      AND N_IDPORTATIL = @portatil 
                                      AND T_PROFESSOR = @professor";
                    cmd.Parameters.AddWithValue("@aluno", idAluno);
                    cmd.Parameters.AddWithValue("@portatil", idPortatil);
                    cmd.Parameters.AddWithValue("@professor", professor.Trim());
                    cmd.ExecuteNonQuery();

                    // Apagar todos os levantamentos com os mesmos critérios (hora, data, professor, aluno, portátil)
                    cmd.CommandText = @"DELETE FROM tb_Levantamentos 
                                    WHERE N_HORALEVANTAMENTO = @hora 
                                      AND D_DATALEVANTAMENTO = @data 
                                      AND T_PROFESSOR = @professor 
                                      AND N_IDALUNO = @aluno 
                                      AND N_IDPORTATIL = @portatil";
                    cmd.Parameters.AddWithValue("@hora", hora);
                    cmd.Parameters.AddWithValue("@data", data);
                    cmd.Parameters.AddWithValue("@professor", professor.Trim());
                    cmd.Parameters.AddWithValue("@aluno", idAluno);
                    cmd.Parameters.AddWithValue("@portatil", idPortatil);
                    cmd.ExecuteNonQuery();

                    // Confirmar a transação
                    transacao.Commit();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao apagar levantamento: " + ex.Message);
        }
        finally
        {
            conexao.Close();
        }
    }





    public static DataTable ObterReservasPorData(string dataReserva)
    {

        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                

                cmd.CommandText = "SELECT N_IDREQUISIÇÃO AS ID, T_PROFESSORRESPONSAVEL AS Professor, T_TURMA AS Turma,strftime('%H:%M', T_HORAINICIO) AS Inicio, strftime('%H:%M', T_HORAFIM) AS Fim,     N_NºPORTATEIS AS Portateis,      T_DATAREQUISIÇÃO AS Data FROM tb_requisiçõesComputadores WHERE T_DATAREQUISIÇÃO <= date('now', 'localtime')  AND T_DATAREQUISIÇÃO = @T_DATAREQUISIÇÃO;";

                // Adicionar parâmetros
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", dataReserva);
                

                // Passar o comando correto para o adaptador
                da = new SQLiteDataAdapter(cmd);

                // Preencher a DataTable com os resultados
                da.Fill(dt);
            }

            // Fechar a conexão após o uso
            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas por Data: " + ex.Message);
        }
    }
    public static DataTable ObterReservasPorData2(string dataReserva)
    {

        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = "SELECT N_IDREQUISIÇÃO AS ID, T_PROFESSORRESPONSAVEL AS Professor, T_TURMA AS Turma,strftime('%H:%M', T_HORAINICIO) AS Inicio, strftime('%H:%M', T_HORAFIM) AS Fim,     N_NºPORTATEIS AS Portateis,      T_DATAREQUISIÇÃO AS Data FROM tb_requisiçõesComputadores WHERE T_DATAREQUISIÇÃO >= date('now', 'localtime')  AND T_DATAREQUISIÇÃO = @T_DATAREQUISIÇÃO;";

                // Adicionar parâmetros
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", dataReserva);


                // Passar o comando correto para o adaptador
                da = new SQLiteDataAdapter(cmd);

                // Preencher a DataTable com os resultados
                da.Fill(dt);
            }

            // Fechar a conexão após o uso
            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas por Data: " + ex.Message);
        }
    }
    public static DataTable ObterReservasIguais(Requisições requisições, int idRequisicaoAtual)
    {

        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = @"
                                    SELECT 
                                        N_IDREQUISIÇÃO AS ID,
                                        T_PROFESSORRESPONSAVEL AS Professor,
                                        T_TURMA AS Turma,
                                        strftime('%H:%M', T_HORAINICIO) AS Inicio,
                                        strftime('%H:%M', T_HORAFIM) AS Fim,
                                        N_NºPORTATEIS AS Portateis,
                                        T_DATAREQUISIÇÃO AS Data
                                    FROM 
                                        tb_requisiçõesComputadores
                                    WHERE 
                                        T_DATAREQUISIÇÃO = @T_DATAREQUISIÇÃO
                                        AND T_PROFESSORRESPONSAVEL = @professor
                                        AND T_TURMA = @turma
                                        AND N_NºPORTATEIS = @quantidade
                                        AND N_IDREQUISIÇÃO != @idAtual; ";




                // Adicionar parâmetros
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", requisições.T_DATAREQUISIÇÃO.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@professor", requisições.T_PROFESSORRESPONSAVEL); // Ex: txt_professor.Text
                cmd.Parameters.AddWithValue("@turma", requisições.T_TURMA); // Podes obter pela ligação ao aluno, se necessário
                cmd.Parameters.AddWithValue("@quantidade", requisições.N_NºPORTATEIS); // Ex: int.Parse(txt_quantidade.Text)
                cmd.Parameters.AddWithValue("@idAtual", idRequisicaoAtual); // ID da requisição já levantada



                // Passar o comando correto para o adaptador
                da = new SQLiteDataAdapter(cmd);

                // Preencher a DataTable com os resultados
                da.Fill(dt);
            }

            // Fechar a conexão após o uso
            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas iguas: " + ex.Message);
        }
    }
    public static DataTable ObterReservasPorProfessor(string professor)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = @"
                SELECT 
                    N_IDREQUISIÇÃO AS ID, 
                    T_PROFESSORRESPONSAVEL AS Professor, 
                    T_TURMA AS Turma, 
                    strftime('%H:%M', T_HORAINICIO) AS Inicio, 
                    strftime('%H:%M', T_HORAFIM) AS Fim, 
                    N_NºPORTATEIS AS Portateis, 
                    T_DATAREQUISIÇÃO AS Data
                FROM 
                    tb_requisiçõesComputadores 
                WHERE 
                    T_DATAREQUISIÇÃO <= date('now', 'localtime') 
                    AND T_PROFESSORRESPONSAVEL LIKE @T_PROFESSORRESPONSAVEL;
            ";

                cmd.Parameters.AddWithValue("@T_PROFESSORRESPONSAVEL", $"%{professor}%");

                da = new SQLiteDataAdapter(cmd);

                da.Fill(dt);
            }

            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas por professor: " + ex.Message);
        }
    }
    public static DataTable ObterReservasPorProfessor2(string professor)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = @"
                SELECT 
                    N_IDREQUISIÇÃO AS ID, 
                    T_PROFESSORRESPONSAVEL AS Professor, 
                    T_TURMA AS Turma, 
                    strftime('%H:%M', T_HORAINICIO) AS Inicio, 
                    strftime('%H:%M', T_HORAFIM) AS Fim, 
                    N_NºPORTATEIS AS Portateis, 
                    T_DATAREQUISIÇÃO AS Data
                FROM 
                    tb_requisiçõesComputadores 
                WHERE 
                    T_DATAREQUISIÇÃO >= date('now', 'localtime') 
                    AND T_PROFESSORRESPONSAVEL LIKE @T_PROFESSORRESPONSAVEL;
            ";

                cmd.Parameters.AddWithValue("@T_PROFESSORRESPONSAVEL", $"%{professor}%");

                da = new SQLiteDataAdapter(cmd);

                da.Fill(dt);
            }

            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas por professor: " + ex.Message);
        }
    }
    public static DataTable ObterReservasPorHorario_Data(string horarioInicio, string horarioFim, DateTime dataRequisicao)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                string dataFormatada = dataRequisicao.ToString("yyyy-MM-dd");
                cmd.CommandText = @"
            SELECT 
                N_IDREQUISIÇÃO AS ID, 
                T_PROFESSORRESPONSAVEL AS Professor, 
                T_TURMA AS Turma, 
                strftime('%H:%M', T_HORAINICIO) AS Inicio, 
                strftime('%H:%M', T_HORAFIM) AS Fim, 
                N_NºPORTATEIS AS Portateis, 
                T_DATAREQUISIÇÃO AS Data
            FROM 
                tb_requisiçõesComputadores
            WHERE 
                T_DATAREQUISIÇÃO = @T_DATAREQUISIÇÃO
                AND strftime('%H:%M', T_HORAINICIO) = @HORARIO_INICIO
                AND strftime('%H:%M', T_HORAFIM) = @HORARIO_FIM";

                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", dataFormatada);
                cmd.Parameters.AddWithValue("@HORARIO_INICIO", horarioInicio);
                cmd.Parameters.AddWithValue("@HORARIO_FIM", horarioFim);
                da = new SQLiteDataAdapter(cmd);

                da.Fill(dt);
            }

            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter as reservas por professor: " + ex.Message);
        }
    }
    public static string ObterDescriçaoReservas(int idRequisicao)
    {
        try
        {
            conexao.Open();

            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "SELECT T_DESCRIÇAO FROM tb_requisiçõesComputadores WHERE N_IDREQUISIÇÃO = @idRequisicao";
                cmd.Parameters.AddWithValue("@idRequisicao", idRequisicao);

                // Executa o comando e obtém o resultado
                var resultado = cmd.ExecuteScalar();

                // Verifica se o resultado não é nulo e retorna a descrição
                return resultado != null ? resultado.ToString() : "Descrição não encontrada.";
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao obter descrição: " + ex.Message);
            return "Erro inesperado ao obter descrição.";
        }
        finally
        {
            conexao.Close();
        }
    }
    public static void AtualizarCartão(Alunos a)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = @"
                UPDATE tb_cartoes 
                SET 
                    T_NOME = @Nome,
                    N_NUMERO = @Numero,
                    N_TRIENIO = @Trienio,
                    T_CURSO = @Curso,
                    I_FTALUNO = @FotoAluno,
                    I_CARTAO = @ImagemCartao
                WHERE 
                    N_IDCARTAO = @ID";

                cmd.Parameters.AddWithValue("@Nome", a.T_NOME);
                cmd.Parameters.AddWithValue("@Numero", a.N_NUMERO);
                cmd.Parameters.AddWithValue("@Trienio", a.N_TRIENIO);
                cmd.Parameters.AddWithValue("@Curso", a.T_CURSO);
                cmd.Parameters.AddWithValue("@FotoAluno",  a.I_FTALUNO); // Bytes da imagem do aluno
                cmd.Parameters.AddWithValue("@ImagemCartao", a.I_CARTAO); // Bytes da imagem do cartão
                cmd.Parameters.AddWithValue("@ID", a.Id_Cartão);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable ObterTurmas()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDTURMA AS ID, T_TURMA AS Turma, T_DIRETORTURMA AS [Diretor de Turma], T_CURSO AS Curso FROM tb_turmas";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable ObterTodasTurmas()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_turmas";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static DataTable ObterNomeTurmas()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT T_TURMA FROM tb_turmas";
                da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                da.Fill(dt);
                ConexaoBanco().Close();
                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void NovaTurma(Turma turma)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_turmas(T_TURMA, T_DIRETORTURMA, T_CURSO) VALUES(@T_TURMA, @T_DIRETORTURMA, @T_CURSO)";
                cmd.Parameters.AddWithValue("@T_TURMA", turma.T_TURMA);
                cmd.Parameters.AddWithValue("@T_DIRETORTURMA", turma.T_DIRETORTURMA);
                cmd.Parameters.AddWithValue("@T_CURSO", turma.T_CURSO);
                cmd.ExecuteNonQuery();

                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao criar Turma: " + ex.Message);
            ConexaoBanco().Close();
        }
    }
    public static void ApagarTurma(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_turmas WHERE N_IDTURMA=" + id;
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }

    }
    public static void AtualizarTurma(Turma t)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = "UPDATE tb_turmas SET T_TURMA=@T_TURMA, T_DIRETORTURMA=@T_DIRETORTURMA, T_CURSO=@T_CURSO WHERE N_IDTURMA=@N_IDTURMA";
                cmd.Parameters.AddWithValue("@T_TURMA", t.T_TURMA);
                cmd.Parameters.AddWithValue("@T_DIRETORTURMA", t.T_DIRETORTURMA);
                cmd.Parameters.AddWithValue("T_CURSO", t.T_CURSO);
                cmd.Parameters.AddWithValue("@N_IDTURMA", t.N_IDTURMA);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void ApagarProfessor(string id)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM tb_professores WHERE N_IDPROFESSOR =" + id;
                cmd.ExecuteNonQuery();

            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            conexao.Close();
        }

    }
    public static void AtualizarProfessor(Professor p)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {

                cmd.CommandText = "UPDATE tb_professores SET T_NOMEPROFESSOR=@T_NOMEPROFESSOR WHERE N_IDPROFESSOR=@N_IDPROFESSOR";
                cmd.Parameters.AddWithValue("@T_NOMEPROFESSOR", p.T_NOMEPROFESSOR);
                cmd.Parameters.AddWithValue("@N_IDPROFESSOR", p.N_IDPROFESSOR);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    public static void NovoProfessor(Professor p)
    {
        try
        {
            conexao.Open();
            using (var cmd = conexao.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO tb_professores(T_NOMEPROFESSOR) VALUES(@T_NOMEPROFESSOR)";
                cmd.Parameters.AddWithValue("@T_NOMEPROFESSOR", p.T_NOMEPROFESSOR);
                cmd.ExecuteNonQuery();

                ConexaoBanco().Close();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao criar Professor: " + ex.Message);
            ConexaoBanco().Close();
        }
    }
    public static DataTable ObterCartãoesPorTurma(string turma)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = @"SELECT N_IDCARTAO as 'ID', T_NOME as 'Nome', N_NUMERO as 'Número' 
                             FROM tb_cartoes c
                             JOIN tb_turmas t ON c.T_CURSO = t.T_CURSO
                             WHERE t.T_TURMA = @T_TURMA";



                cmd.Parameters.AddWithValue("@T_TURMA", turma);

                da = new SQLiteDataAdapter(cmd);

                da.Fill(dt);
            }

            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter os cartões por turma: " + ex.Message);
        }
    }
    public static DataTable ObterCartãoesPorAluno(string aluno)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = @"SELECT N_IDCARTAO as 'ID', T_NOME as 'Nome', N_NUMERO as 'Número' 
                             FROM tb_cartoes 
                            WHERE T_NOME LIKE '%' || @T_NOME || '%'";



                cmd.Parameters.AddWithValue("@T_NOME", aluno);

                da = new SQLiteDataAdapter(cmd);

                da.Fill(dt);
            }

            ConexaoBanco().Close();
            return dt;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao obter os cartões por turma: " + ex.Message);
        }
    }
    public static DataTable ObterCartõesSelecionados(List<int> ids)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            if (ids == null || ids.Count == 0)
                return dt; // Retorna um DataTable vazio se a lista de IDs estiver vazia

            using (var cmd = ConexaoBanco().CreateCommand())
            {
                // Cria a string com os IDs diretamente na query
                string idList = string.Join(",", ids);

                    // Query utilizando os IDs diretamente na string
                    cmd.CommandText = $@"SELECT I_CARTAO, I_QRCODE 
                                     FROM tb_cartoes 
                                     WHERE N_IDCARTAO IN ({idList})";

                    da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);
                }
            

            return dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao obter os cartões: " + ex.Message);
            return dt;
        }
    }

}



