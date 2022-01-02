using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Text;
using System.Windows.Forms;
using M17.GestFarmacy.helpers;

namespace M17.GestFarmacy.DataBase
{
    class Database
    {
 
    

//====================================================================
// classe que permite gerir bases de dados
// versão 1.0.0
//====================================================================

        SqlCeConnection ligacao;
        SqlCeCommand comando;
        SqlCeDataAdapter adaptador;

        SqlCeDataAdapter adaptador_temp;


        string strConn = null;
        string pasta_bd = Application.StartupPath + @"\DataBaseFiles\";
        string bd_password = "";

        //cria a classe de parametros de SQL
        public class SQLParametro
        {
            public string parametro { get; set; }
            public object valor { get; set; }

            public SQLParametro(string parametro, object valor)
            {
                this.parametro = parametro;
                this.valor = valor;
            }
        }

        //============================================================
        public Database()
        { }

        //============================================================
        public void CriarBaseDados(string base_dados, List<string> instrucoes, bool verificar_ficheiro = false)
        {
            //----------------------------------------------------------
            #region CRIAR FICHEIRO
            //criar uma base de dados nova
            #region verficação da existência de ficheiro de base de dados
            if (verificar_ficheiro)
            {
                //executa a verificação
                if (File.Exists(base_dados))
                {
                    if (MessageBox.Show("Existe uma base de dados com o mesmo nome." + Environment.NewLine +
                                        "Deseja substituir a base de dados existente?",
                                        "ATENÇÃO",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        //apagar o ficheiro existente
                        try
                        {
                            File.Delete(base_dados);
                        }
                        catch
                        {
                            MessageBox.Show("Aconteceu um erro ao eliminar a base de dados.");
                            return;
                        }
                    }
                }
            }
            #endregion

            //construção da connectionstring
            StringBuilder str = new StringBuilder();
            str.Append("Data source = ");

            //nome da base de dados
            str.Append(base_dados);

            //verificar se tem password
            if (bd_password != "")
                str.Append("; Password = " + bd_password);

            //criação da base de dados
            SqlCeEngine motor = new SqlCeEngine(str.ToString());
            motor.CreateDatabase();
            #endregion

            //----------------------------------------------------------
            #region CRIAÇÃO DAS TABELAS
            ligacao = new SqlCeConnection(str.ToString());
            ligacao.Open();
            comando = new SqlCeCommand();
            comando.Connection = ligacao;

            //executa as instruções para criar as tabelas
            str = null;            
            foreach (string item in instrucoes)
            {
                if (item.StartsWith("CREATE TABLE"))
                {
                    //inicia a construção da query
                    str = new StringBuilder();
                    str.Append(item);
                }
                else if (item == "FIM")
                {
                    //fechar a criação da query e executá-la
                    comando.CommandText = str.ToString();
                    comando.ExecuteNonQuery();
                }
                else
                {
                    //adicionar instrução ao stringbuilder
                    str.Append(item);
                }
            }

            //fecha o comando e a ligação.
            comando.Dispose();
            ligacao.Dispose();
            #endregion
        }

        //============================================================
        public Database(string base_dados)
        {
            //definir a connectionstring da ligação
            //strConn = "Data source = " + pasta_bd + base_dados + ".sdf; Password = " + bd_password;
            StringBuilder str = new StringBuilder();

            //define a base da strConn
            str.Append("Data source = ");

            //se existe pasta/localização definida...
            if (pasta_bd != "")
            {
                str.Append(pasta_bd);
            }

            //acrescenta o nome do ficheiro da base de dados
            str.Append(base_dados + ".sdf");

            //adiciona a password se for necessário
            if (bd_password != "")
            {
                str.Append("; Password = " + bd_password);
            }

            //define finalmente a strConn
            strConn = str.ToString();
        }

        //============================================================
        public DataTable EXE_READER(string query, List<SQLParametro> parametros = null)
        {
            //pesquisar informações da base de dados
            DataTable dados = new DataTable();
            adaptador = new SqlCeDataAdapter(query, strConn);
            adaptador.SelectCommand.Parameters.Clear();

            //executar a query
            try
            {
                //insere os parâmetros na query
                if (parametros != null)
                {
                    foreach (SQLParametro p in parametros)
                        adaptador.SelectCommand.Parameters.AddWithValue(p.parametro, p.valor);
                }

                adaptador.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            adaptador.Dispose();
            return dados;
        }

        //============================================================
        public void EXE_NON_QUERY(string query, List<SQLParametro> parametros = null,bool exibir = false)
        {
            //executar queries do tipo INSERT, DELETE, UPDATE, CREATE TABLE, etc.
            ligacao = new SqlCeConnection(strConn);
            ligacao.Open();
            comando = new SqlCeCommand(query, ligacao);
            comando.Parameters.Clear();

            try
            {
                //adição de parâmetros no comando
                if (parametros != null)
                {
                    foreach (SQLParametro p in parametros)
                        comando.Parameters.AddWithValue(p.parametro, p.valor);
                }

                //executar a query
                comando.ExecuteNonQuery();
                //Exibir sms
                if (exibir == true)
                {
                    helpers.helpers.CriarMensagem("A Operação foi um sucesso!", 1);
                }
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

            //destruir a ligação e o comando
            comando.Dispose();
            ligacao.Dispose();
        }

        //============================================================

        //============================================================
        public int ID_DISPONIVEL(string tabela, string coluna)
        {
            //devolve o ID disponível para o próximo registo
            int idtemp = -1;

            string query = "SELECT MAX(" + coluna + ") AS MaxID FROM " + tabela;
            DataTable dados = new DataTable();
            adaptador = new SqlCeDataAdapter(query, strConn);
            adaptador.Fill(dados);

            //verifica se é DBNull ou não
            if (dados.Rows.Count != 0)
            {
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    idtemp = 0;
                else
                    idtemp = Convert.ToInt16(dados.Rows[0][0]) + 1;
            }
            
            return idtemp;
        }

        //============================================================
        public int LAST_ID(string tabela, string coluna)
        {
            //devolve o ultimo ID inserido
            int idtemp = -1;

            string query = "SELECT MAX(" + coluna + ") AS MaxID FROM " + tabela;
            DataTable dados = new DataTable();
            adaptador = new SqlCeDataAdapter(query, strConn);
            adaptador.Fill(dados);

            //verifica se é DBNull ou não
            if (dados.Rows.Count != 0)
            {
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                    idtemp = 0;
                else
                    idtemp = Convert.ToInt16(dados.Rows[0][0]);
            }

            return idtemp;
        }

        //============================================================
        public DataTable PREPARAR_DATATABLE(string query)
        {
            //preparar a datatable para atualização ou inserção de dados
            adaptador_temp = new SqlCeDataAdapter(query, strConn);
            DataTable dados = new DataTable();
            try
            {
                adaptador_temp.Fill(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return dados;
        }

        //============================================================
        public void GRAVAR_DATATABLE(DataTable dados)
        {
            //atualiza a informação na base de dados
            SqlCeCommandBuilder cmd = new SqlCeCommandBuilder(adaptador_temp);
            adaptador_temp.UpdateCommand = cmd.GetUpdateCommand();

            try
            {
                adaptador_temp.Update(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }

            adaptador_temp.Dispose();
        }

        //============================================================
        public bool COMPACTAR_BASE_DADOS()
        {
            //compacta a base de dados
            bool concluido = false;

            try
            {
                SqlCeEngine motor = new SqlCeEngine();
                motor.LocalConnectionString = strConn;
                motor.Compact(strConn);
                concluido = true;
            }
            catch (Exception ex)
            {
                concluido = false;
                MessageBox.Show("ERRO: " + ex.Message);
            }

            return concluido;
        }
    }
}
