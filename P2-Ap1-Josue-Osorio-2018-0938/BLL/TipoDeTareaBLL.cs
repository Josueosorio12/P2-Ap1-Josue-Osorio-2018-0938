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
   public class TipoDeTareaBLL
    {
        public static TipoTarea Buscar(int id)
        {
            TipoTarea tarea;
            Contexto contexto = new Contexto();

            try
            {
                tarea = contexto.TipoTarea.Find(id);
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
        public static List<TipoTarea> GetTiposTarea()
        {
            List<TipoTarea> lista = new List<TipoTarea>();

            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TipoTarea.ToList();
            }
            catch (Exception)
            {
               // throw; tengo una exepcion
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
        public static List<TipoTarea> GetList(Expression<Func<TipoTarea, bool>> criterio)
        {
            List<TipoTarea> Lista = new List<TipoTarea>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.TipoTarea.Where(criterio).ToList();
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
    
