using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using lib_repositorios.Implementaciones;
using Microsoft.EntityFrameworkCore;
using ut_presentacion.Nucleo;

namespace ut_presentacion.Repositorios
{
    [TestClass]
    public class JugadorEquipoPrueba
    {
        private readonly IConexion? iConexion;
        private List<JugadorEquipo>? lista;
        private JugadorEquipo? entidad;

        public JugadorEquipoPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }

        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }

        public bool Listar()
        {
            this.lista = this.iConexion!.JugadoresEquipos!.ToList();
            return lista.Count > 0;
        }

        public bool Guardar()
        {
            this.entidad = new JugadorEquipo()
            {
                // TODO: Asignar propiedades iniciales
            };
            this.iConexion!.JugadoresEquipos!.Add(this.entidad);
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Modificar()
        {
            // TODO: Cambiar alguna propiedad
            var entry = this.iConexion!.Entry<JugadorEquipo>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }

        public bool Borrar()
        {
            this.iConexion!.JugadoresEquipos!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }
}
