using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    interface Controlador<T>
    {
        int guardar(T t);
        bool modificar(T t);
        List<T> getRecursos();
        T buscarPorID(int id);
    }
}
