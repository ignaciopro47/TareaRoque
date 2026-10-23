using System;

namespace Company.ClassLibrary1;

public class ProductoServicio
{
    private readonly AppDbContext _context
    {
        _context = context;
    }

    public void agregar(string Nombre, decimal Precio)
    {
        Nombre = Nombre,
        Precio = Precio

    };

    _context.Productos.Add(Producto)
    _context.SaveChanges();
}

public list<Producto> ObtenerTodos()
{
    return _return.Productos.Tolist();
}
