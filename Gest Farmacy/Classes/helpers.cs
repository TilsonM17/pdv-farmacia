using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using M17.GestFarmacy.DataBase;

namespace M17.GestFarmacy.helpers
{
     static class helpers
     {
         /*
          * @Return Void
          * @params sms - O Texto a ser exibido na tela do usuario
          * tipo - O tipo de Mnesagem que vamos exibir
          *   1- Sucesso
          *   2- Erro
          *   3- Aviso
          
          */
         public static void CriarMensagem(string sms,int tipo) {

             switch (tipo)
             {
                 case 1:
                     MessageBox.Show(sms,"Informação Processada com sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                     break;
                 case 2:
                     MessageBox.Show(sms, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     break;
                 case 3:
                     MessageBox.Show(sms, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     break;
                 default:
                     MessageBox.Show("Erro Interno do Sistema,Não posso exeibir mais Mensagem", "Algo de errado aconteceu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     break;
             }
          
                
         }


         public static DataTable CriarGrelha(string nome_tabela) {

             DataTable tabela = new DataTable();

             Database db = new Database("db_farmacia");
             tabela = db.EXE_READER("SELECT * FROM "+ nome_tabela);

             return tabela;

         
         
         }

         public static void LimparGrelha() { 
         }

     }
} 
