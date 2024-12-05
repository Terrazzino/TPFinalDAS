using Microsoft.EntityFrameworkCore;
using Modelo;
using Modelo.Objetos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        Contexto _contexto = new Contexto();

        public ReadOnlyCollection<Categoria> LeerCategorias()
        {
            return _contexto.Categorias.ToList().AsReadOnly();
        }
        public void RegistrarCategoria(Categoria categoria)
        {
            var validarDuplicado = _contexto.Categorias.FirstOrDefault(x=>x.Codigo==categoria.Codigo);
            if (validarDuplicado==null)
            {
                _contexto.Categorias.Add(categoria);
                _contexto.SaveChanges();
            }
        }
        public void EliminarCategoria(Categoria categoria)
        {
            _contexto.Categorias.Remove(categoria);
            _contexto.SaveChanges();
        }
        public void ModificarCategoria(Categoria categoriaActualizada)
        {
            _contexto.Categorias.Update(categoriaActualizada);
            _contexto.SaveChanges();
        }
    }
}
