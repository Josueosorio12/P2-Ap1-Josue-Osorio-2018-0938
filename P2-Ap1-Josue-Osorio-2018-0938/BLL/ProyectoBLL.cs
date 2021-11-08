using Microsoft.EntityFrameworkCore;
using P2_Ap1_Josue_Osorio_2018_0938.DAL;
using P2_Ap1_Josue_Osorio_2018_0938.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace P2_Ap1_Josue_Osorio_2018_0938.BLL
{
    public class ProyectoBLL
    {
        public static bool Guardar(Proyectos proyecto)
        {
            if (!Existe(proyecto.Proyectoid))
                return Insertar(proyecto);
            else
                return Modificar(proyecto);
        }
        private static bool Insertar(Proyectos proyecto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Proyectos.Add(proyecto);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        private static bool Modificar(Proyectos proyecto)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM TipoDetalle Where Proyectoid={proyecto.Proyectoid}");

                foreach (var item in proyecto.TipoDetalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }

                contexto.Entry(proyecto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var proyecto = ProyectoBLL.Buscar(id);

                if (proyecto != null)
                {
                    contexto.Proyectos.Remove(proyecto);
                    paso = contexto.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static Proyectos Buscar(int id)
        {
            Proyectos tarea = new Proyectos();
            Contexto contexto = new Contexto();

            try
            {
                tarea = contexto.Proyectos.Include(x => x.TipoDetalle).Where(x => x.Proyectoid == id).SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tarea;
        }
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Proyectos.Any(e => e.Proyectoid == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }
        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> criterio)
        {
            List<Proyectos> Lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Proyectos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}

  
