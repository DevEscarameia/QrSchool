using app;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

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
                cmd.CommandText = "INSERT INTO tb_cartoes(T_NOME, N_NUMERO, N_TRIENIO, T_CURSO, I_FTALUNO, I_QRCODE) VALUES(@T_NOME, @N_NUMERO, @N_TRIENIO, @T_CURSO, @I_FTALUNO, @I_QRCODE)";
                    cmd.Parameters.AddWithValue("@T_NOME", aluno.T_NOME);
                    cmd.Parameters.AddWithValue("@N_NUMERO", aluno.N_NUMERO);
                    cmd.Parameters.AddWithValue("@N_TRIENIO", aluno.N_TRIENIO);
                    cmd.Parameters.AddWithValue("@T_CURSO", aluno.T_CURSO);
                    cmd.Parameters.AddWithValue("@I_FTALUNO", aluno.I_FTALUNO);
                    cmd.Parameters.AddWithValue("@I_QRCODE", aluno.I_QRCODE);
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
    public static DataTable ObterDataRequisição() 
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();
        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT T_DATAREQUISIÇÃO FROM tb_requisiçõesComputadores GROUP BY T_DATAREQUISIÇÃO";
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
                cmd.CommandText = "INSERT INTO tb_requisiçõesComputadores(T_PROFESSORRESPONSAVEL, T_TURMA, T_HORARIO, N_NºPORTATEIS, T_DATAREQUISIÇÃO) VALUES(@T_PROFESSORRESPONSAVEL, @T_TURMA, @T_HORARIO, @N_NºPORTATEIS, @T_DATAREQUISIÇÃO)";
                cmd.Parameters.AddWithValue("@T_PROFESSORRESPONSAVEL", requisições.T_PROFESSORRESPONSAVEL);
                cmd.Parameters.AddWithValue("@T_TURMA", requisições.T_TURMA);
                cmd.Parameters.AddWithValue("@T_HORARIO", requisições.T_HORARIO);
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

    public static DataTable TodasRequisições()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT *  FROM tb_requisiçõesComputadores";
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
    public static DataTable TodasRequisiçõesFeitas()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT N_IDREQUISIÇÃOFEITA AS 'Id Feitas', " +
                                         "N_IDREQUISIÇÃO AS 'Id Requisição', " +
                                         "T_NOMEALUNO AS 'Nome Aluno', " +
                                         "N_NUMEROPORTATIL AS 'Numero Portatil', " +
                                         "N_HORALEVANTAMENTO AS 'Hora' " +
                                         "FROM tb_requisiçõesFeitas";
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
    public static DataTable ObterReservasPorTurma(string turma)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_requisiçõesComputadores WHERE T_TURMA = @Turma";
                cmd.Parameters.AddWithValue("@Turma", turma);
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
    public static DataTable ObterReservasPorData(string Data)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_requisiçõesComputadores WHERE T_DATAREQUISIÇÃO = @Data";
                cmd.Parameters.AddWithValue("@Data", Data);
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
    public static DataTable ObterReservasPorHora(string Hora)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_requisiçõesComputadores WHERE T_HORARIO = @Hora";
                cmd.Parameters.AddWithValue("@Hora", Hora);
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
    public static DataTable ObterReservasPorProfessor(string Professor)
    {
        try
        {
            conexao.Open();
            using (var cmd = ConexaoBanco().CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM tb_requisiçõesComputadores WHERE T_PROFESSORRESPONSAVEL = @Professor";
                cmd.Parameters.AddWithValue("@Professor", Professor);
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


}