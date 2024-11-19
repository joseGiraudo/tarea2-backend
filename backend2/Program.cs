
using biblioteca;


Console.WriteLine("Hello, World!");

UsuarioDAO usuarioDAO = new UsuarioDAO();

// Obtener usuarios
IEnumerable<Usuario> usuarios = usuarioDAO.GetAll();
foreach (var u in usuarios)
{
    Console.WriteLine($"Nombre: {u.Nombre}, Edad: {u.Edad}, Activo: {u.Activo}");
}

// crear usuario 
Usuario usuario = new Usuario("Julia", 31);
int affectedRows = usuarioDAO.Create(usuario);
Console.WriteLine($"Se insertaron {affectedRows} usuarios");

// obtener por id
Usuario usuario1 = usuarioDAO.GetById(3);
if (usuario1 == null)
{
    Console.WriteLine("No se encontro el suuario");
}
else
{
    Console.WriteLine($"Nombre: {usuario1.Nombre}, Edad: {usuario1.Edad}, Activo: {usuario1.Activo}");
}

// update el suuario encontrado
if (usuario1 != null)
{
    usuario1.Nombre = "Julia 2";
    usuario1.Edad = 32;
    int filas = usuarioDAO.Update(usuario1);
    Console.WriteLine($"Se actualizó {filas} usuario");
}


// borrado logico
int filas2 = usuarioDAO.DeleteById(usuario1.Id);
Console.WriteLine($"Se Borraron {filas2} usuarios");

// ver si se borro
Usuario usuarioEliminado = usuarioDAO.GetById(usuario1.Id);
if (usuario1 == null)
{
    Console.WriteLine("No se encontro el suuario");
}
else
{
    Console.WriteLine($"Nombre: {usuario1.Nombre}, Edad: {usuario1.Edad}, Activo: {usuario1.Activo}");
}

Console.ReadLine();