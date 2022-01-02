using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace M17.cl_converter
{
     static class cl_converter
    {
       
            public static DataTable ConverteListaString(List<string> lista)
            {
                // Cria Novo DataTable
                DataTable table = new DataTable();
                // Numero maximo de colunas
                int columns = 0;

                foreach (var array in lista)
                {
                    if (array.Length > columns)
                    {
                        columns = array.Length;
                    }
                }
                // incluir colunas
                for (int i = 0; i < columns; i++)
                {
                    table.Columns.Add();
                }

                // inclui linhas
                foreach (var array in lista)
                {
                    table.Rows.Add(array);
                }
                return table;
            }
            public static DataTable ConverteListaNumero(List<int[]> lista)
            {
                // Cria Novo DataTable
                DataTable table = new DataTable();
                // Numero maximo de colunas
                int columns = 0;
                foreach (var array in lista)
                {
                    if (array.Length > columns)
                    {
                        columns = array.Length;
                    }
                }
                // incluir colunas
                for (int i = 0; i < columns; i++)
                {
                    table.Columns.Add();
                }

                // inclui linhas
                foreach (var array in lista)
                {
                    table.Rows.Add(array);
                }
                return table;
            }

           
    }
  
}
