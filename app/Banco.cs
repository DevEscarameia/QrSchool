using app;
using app.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

internal class Banco
{

    private static SQLiteConnection conexao;

    //Faz a conexão a Db

    private static SQLiteConnection ConexaoBanco()
    {
        if (conexao == null)
        {
            conexao = new SQLiteConnection("Data Source= C:\\Users\\duart\\Desktop\\app\\app\\Banco\\db_escola;Version=3;");
            conexao.Open();
        }

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
    public static DataTable TodosCartões()
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
            MessageBox.Show("Erro ao criar utilizador: " + ex.Message);
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

    //função para obter as turmas que tem reserva feita 
    public static DataTable ObterTurmas()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT T_TURMA FROM tb_requisiçõesComputadores GROUP BY T_TURMA";
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
                cmd.CommandText = "INSERT INTO tb_requisiçõesComputadores(T_PROFESSORRESPONSAVEL, T_TURMA, T_HORAINICIO,T_HORAFIM, N_NºPORTATEIS, T_DATAREQUISIÇÃO) VALUES(@T_PROFESSORRESPONSAVEL, @T_TURMA, @T_HORAINICIO,@T_HORAFIM, @N_NºPORTATEIS, @T_DATAREQUISIÇÃO)";
                cmd.Parameters.AddWithValue("@T_PROFESSORRESPONSAVEL", requisições.T_PROFESSORRESPONSAVEL);
                cmd.Parameters.AddWithValue("@T_TURMA", requisições.T_TURMA);
                cmd.Parameters.AddWithValue("@T_HORAINICIO", requisições.T_HORAINICIO);
                cmd.Parameters.AddWithValue("@T_HORAFIM", requisições.T_HORAFIM);
                cmd.Parameters.AddWithValue("@N_NºPORTATEIS", requisições.N_NºPORTATEIS);
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", requisições.T_DATAREQUISIÇÃO.ToString("yyyy-MM-dd"));
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
                  "N_IDALUNO AS 'ID Aluno', " +
                  "N_IDPORTATIL AS 'ID Portátil', " +
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
    public static DataTable TodosComputadore()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT *  FROM tb_portateis";
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
    public static void ApagarEntrega(string id)
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
                        cmd.CommandText = "DELETE FROM tb_Entregas WHERE N_IDENTREGA = @N_IDENTREGA";
                        cmd.ExecuteNonQuery();

                        // Atualiza o status do levantamento para "Levantado"
                        cmd.CommandText = "UPDATE tb_Levantamentos SET T_STATUS = 'Levantado' " +
                                          "WHERE N_IDALUNO = @N_IDALUNO AND N_IDPORTATIL = @N_IDPORTATIL AND N_IDREQUISIÇÃO = @N_IDREQUISIÇÃO";
                        cmd.Parameters.Clear(); // Limpar os parâmetros antigos
                        cmd.Parameters.AddWithValue("@N_IDALUNO", idAluno);
                        cmd.Parameters.AddWithValue("@N_IDPORTATIL", idPortatil);
                        cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃO", idRequisicao);
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
                  "N_IDALUNO AS 'ID Aluno', " +
                  "N_IDPORTATIL AS 'ID Portátil', " +
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
    public static void ApagarLevantamentoEEntrega(string idRequisicao)
    {
        try
        {
            conexao.Open();
            using (var transacao = conexao.BeginTransaction())
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.Transaction = transacao;

                    // Buscar o ID do aluno e ID do computador associados ao levantamento
                    cmd.CommandText = "SELECT N_IDALUNO, N_IDPORTATIL FROM tb_Levantamentos WHERE N_IDREQUISIÇÃOFEITA = @N_IDREQUISIÇÃOFEITA";
                    cmd.Parameters.AddWithValue("@N_IDREQUISIÇÃOFEITA", idRequisicao);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var idAluno = reader["N_IDALUNO"].ToString();
                            var idComputador = reader["N_IDPORTATIL"].ToString();
                            reader.Close();

                            // Apagar a entrega com o mesmo ID do aluno e ID do computador
                            cmd.CommandText = "DELETE FROM tb_Entregas WHERE N_IDALUNO = @N_IDALUNO AND N_IDPORTATIL = @N_IDPORTATIL";
                            cmd.Parameters.AddWithValue("@N_IDALUNO", idAluno);
                            cmd.Parameters.AddWithValue("@N_IDPORTATIL", idComputador);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            throw new Exception("Levantamento não encontrado.");
                        }
                    }

                    // Apagar o levantamento
                    cmd.CommandText = "DELETE FROM tb_Levantamentos WHERE N_IDREQUISIÇÃOFEITA = @N_IDREQUISIÇÃOFEITA";
                    cmd.Parameters["@N_IDREQUISIÇÃOFEITA"].Value = idRequisicao;
                    cmd.ExecuteNonQuery();
                }

                // Confirmar transação
                transacao.Commit();
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
    public static DataTable ObterReservasPorData(DateTime dataReserva)
    {

        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                string dataFormatada = dataReserva.ToString("yyyy-MM-dd");

                cmd.CommandText = "SELECT N_IDREQUISIÇÃO AS ID, T_PROFESSORRESPONSAVEL AS Professor, T_TURMA AS Turma,strftime('%H:%M', T_HORAINICIO) AS Inicio, strftime('%H:%M', T_HORAFIM) AS Fim,     N_NºPORTATEIS AS Portateis,      T_DATAREQUISIÇÃO AS Data FROM tb_requisiçõesComputadores WHERE T_DATAREQUISIÇÃO <= date('now', 'localtime')  AND T_DATAREQUISIÇÃO = @T_DATAREQUISIÇÃO;";

                // Adicionar parâmetros
                cmd.Parameters.AddWithValue("@T_DATAREQUISIÇÃO", dataFormatada);
                

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
}

