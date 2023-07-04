using WebApplication1.Models;

namespace WebApplication1.Clases
{
    public class DAO
    {
        public int ValidarUser(Login data)
        {
            using (ProyectoUContext cn =new ProyectoUContext())
            {
                bool existeUsuario = cn.Logins.Any(l => l.Usuario == data.Usuario && l.Contraseña == data.Contraseña);

                if (existeUsuario)
                {
                    // Usuario y contraseña coinciden
                    return 1;
                }
                else
                {
                    // Usuario y contraseña no coinciden
                    return 0;
                }
            }
        }

        public int ContarProductos()
        {
            using (ProyectoUContext cn = new ProyectoUContext())
            {
                int cantidadProductos = cn.Productos.Count();
                return cantidadProductos;
            }
        }

        public int ContarProveedores()
        {
            using (ProyectoUContext cn = new ProyectoUContext())
            {
                int cantidadProveedores = cn.Proveedors.Count();
                return cantidadProveedores;
            }
        }

    }
}
