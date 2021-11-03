using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lucho
{
    public class ListaProd
    {
        public DataTable DT { get; set; } = new DataTable();
        public int UltimoID { get; set; } = 0;

        public ListaProd()
        {
            DT.TableName = "TablaDatos";
            DT.Columns.Add("ID");
            DT.Columns.Add("Categoria");
            DT.Columns.Add("Producto");
            DT.Columns.Add("Cantidad");
            DTArchivo();
        }

        public void DTArchivo()
        {
            if (System.IO.File.Exists("ListadeProductos.xml"))
            {
                DT.Clear();
                DT.ReadXml("ListadeProductos.xml");

                UltimoID = 0;
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    if (Convert.ToInt32(DT.Rows[i]["ID"]) > UltimoID)
                    {
                        UltimoID = Convert.ToInt32(DT.Rows[i]["ID"]);
                    }
                }

            }
        }

        public void CargarDatos(Producto Producto)
        {
            if (Producto.Id == 0)
            {
                UltimoID = UltimoID + 1;
                Producto.Id = UltimoID;

                DT.Rows.Add();
                int Reg = DT.Rows.Count - 1;

                DT.Rows[Reg]["Id"] = Producto.Id.ToString();
                DT.Rows[Reg]["Categoria"] = Producto.Cat;
                DT.Rows[Reg]["Producto"] = Producto.Prod;
                DT.Rows[Reg]["Cantidad"] = Producto.Cant.ToString();

                DT.WriteXml("ListadeProductos.xml");
            }
            else
            {
                for (int fila = 0; fila < DT.Rows.Count; fila++)
                {
                    if (Convert.ToInt32(DT.Rows[fila]["Id"]) == Producto.Id)
                    {
                        DT.Rows[fila]["Categoria"] = Producto.Cat;
                        DT.Rows[fila]["Producto"] = Producto.Prod;
                        DT.Rows[fila]["Cantidad"] = Producto.Cant.ToString();
                        DT.WriteXml("ListadeProductos.xml");
                        break;
                    }
                }
            }
        }

        public Producto BuscarProd(int id)
        {
            Producto Busca = new Producto();
            for (int fila = 0; fila < DT.Rows.Count; fila++)
            {
                if (Convert.ToInt32(DT.Rows[fila]["Id"]) == id)
                {
                    Busca.Id = Convert.ToInt32(DT.Rows[fila]["Id"]);
                    Busca.Cat = DT.Rows[fila]["Categoria"].ToString();
                    Busca.Prod = DT.Rows[fila]["Producto"].ToString();
                    Busca.Cant = Convert.ToInt32(DT.Rows[fila]["Cantidad"]);
                    break;
                }
            }
            return Busca;
        }
    }
}
