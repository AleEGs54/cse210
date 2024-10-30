
// using System;
// using System.IO;
// using System.Collections.Generic;

// string filename = "limatambo.csv";
// string filenameEliminar = "Limatambo-eliminar.csv";
// string filenameActualizado = "Limatambo-actualizado.csv";

// string[] lines = File.ReadAllLines(filename);
// string[] linesEliminar = File.ReadAllLines(filenameEliminar);

// HashSet<string> nombresYApellidosAEliminar = new HashSet<string>();
// HashSet<string> telefonosAEliminar = new HashSet<string>();
// HashSet<string> correosAEliminar = new HashSet<string>();

// // Leer Limatambo-eliminar.csv y extraer nombres, apellidos, teléfonos y correos para las listas de eliminación
// foreach (string line in linesEliminar)
// {
//     string[] parts = line.Split(',');
//     if (parts.Length > 7) // Asegúrate de que la línea tiene suficientes columnas
//     {
//         string nombreEliminar = parts[1].Trim();
//         string apellidoEliminar = parts[2].Trim();
//         string telefonoEliminar = parts[6].Trim();
//         string correoEliminar = parts[7].Trim();

//         // Agregar combinaciones de "Nombre Apellido", teléfonos y correos a las listas de eliminación
//         string nombreApellidoEliminar = $"{nombreEliminar} {apellidoEliminar}";
//         nombresYApellidosAEliminar.Add(nombreApellidoEliminar);
//         telefonosAEliminar.Add(telefonoEliminar);
//         correosAEliminar.Add(correoEliminar);
//     }
// }

// // Crear una lista para almacenar las líneas que se mantendrán
// List<string> linesToKeep = new List<string>();

// // Recorrer cada línea en Limatambo.csv y verificar las condiciones de exclusión
// foreach (string line in lines)
// {
//     string[] parts = line.Split(',');
//     if (parts.Length > 14) // Asegúrate de que la línea tiene suficientes columnas
//     {
//         string nombre = parts[5].Trim();
//         string apellido = parts[6].Trim();
//         string telefono = parts[12].Trim();
//         string correo = parts[14].Trim();

//         // Crear la clave de "Nombre Apellido" para verificar la exclusión
//         string nombreApellido = $"{nombre} {apellido}";

//         // Excluir la línea si el nombre y apellido, teléfono, o correo están en las listas de eliminación
//         if (!nombresYApellidosAEliminar.Contains(nombreApellido) && 
//             !telefonosAEliminar.Contains(telefono) && 
//             !correosAEliminar.Contains(correo))
//         {
//             linesToKeep.Add(line); // Añadir a la lista de líneas que se conservarán
//         }
//     }
// }

// // Escribir las líneas filtradas en el nuevo archivo Limatambo-actualizado.csv
// File.WriteAllLines(filenameActualizado, linesToKeep);

// Console.WriteLine("Archivo 'Limatambo-actualizado.csv' creado con éxito, excluyendo a las personas cuyos nombres y apellidos, teléfonos o correos coinciden con 'Limatambo-eliminar.csv'.");

// using System;
// using System.IO;
// using System.Collections.Generic;

// string filenameEliminar = "Limatambo-eliminar.csv";

// string[] linesEliminar = File.ReadAllLines(filenameEliminar);
// Dictionary<string, int> numeroContador = new Dictionary<string, int>();

// // Leer Limatambo-eliminar.csv y contar los números repetidos
// foreach (string line in linesEliminar)
// {
//     string[] parts = line.Split(',');
//     if (parts.Length > 6) // Asegúrate de que la línea tiene suficientes columnas
//     {
//         string numeroTelefono = parts[6].Trim(); // Cambia el índice según donde esté el número de celular
        
//         if (numeroContador.ContainsKey(numeroTelefono))
//         {
//             numeroContador[numeroTelefono]++; // Incrementar el contador si el número ya existe
//         }
//         else
//         {
//             numeroContador[numeroTelefono] = 1; // Agregar el número al diccionario
//         }
//     }
// }

// // Mostrar los números repetidos y su cantidad
// Console.WriteLine("Números telefónicos repetidos en 'Limatambo-eliminar.csv':");
// foreach (var kvp in numeroContador)
// {
//     if (kvp.Value > 1) // Mostrar solo si el número se repite
//     {
//         Console.WriteLine($"Número: {kvp.Key}, Cantidad: {kvp.Value}");
//     }
// }


// string filename = "limatambo.csv";

// string[] lines = File.ReadAllLines(filename);
// Dictionary<string, int> numeroContador1 = new Dictionary<string, int>();

// // Leer limatambo.csv y contar los números repetidos
// foreach (string line in lines)
// {
//     string[] parts = line.Split(',');
//     if (parts.Length > 12) // Asegúrate de que la línea tiene suficientes columnas
//     {
//         string numeroTelefono = parts[12].Trim(); // Cambia el índice según donde esté el número de celular
        
//         if (numeroContador1.ContainsKey(numeroTelefono))
//         {
//             numeroContador1[numeroTelefono]++; // Incrementar el contador si el número ya existe
//         }
//         else
//         {
//             numeroContador1[numeroTelefono] = 1; // Agregar el número al diccionario
//         }
//     }
// }

// // Mostrar los números repetidos y su cantidad
// Console.WriteLine("Números telefónicos repetidos en 'limatambo.csv':");
// foreach (var kvp in numeroContador1)
// {
//     if (kvp.Value > 1) // Mostrar solo si el número se repite
//     {
//         Console.WriteLine($"Número: {kvp.Key}, Cantidad: {kvp.Value}");
//     }
// }


using System;
using System.IO;
using System.Collections.Generic;

string filename = "limatambo.csv";
string filenameEliminar = "Limatambo-eliminar.csv";
string filenameActualizado = "Limatambo-actualizado.csv";
string filenameEliminarMarcado = "Limatambo-eliminar-marcado.csv"; // Nuevo archivo con las "X"

// Leer los archivos originales
string[] lines = File.ReadAllLines(filename);
string[] linesEliminar = File.ReadAllLines(filenameEliminar);

// Listas de datos a eliminar
HashSet<string> nombresYApellidosAEliminar = new HashSet<string>();
HashSet<string> telefonosAEliminar = new HashSet<string>();
HashSet<string> correosAEliminar = new HashSet<string>();

// Procesar el archivo Limatambo-eliminar.csv para extraer datos de personas a eliminar
foreach (string line in linesEliminar)
{
    string[] parts = line.Split(',');
    if (parts.Length > 7)
    {
        string nombreEliminar = parts[1].Trim();
        string apellidoEliminar = parts[2].Trim();
        string telefonoEliminar = parts[6].Trim();
        string correoEliminar = parts[7].Trim();

        string nombreApellidoEliminar = $"{nombreEliminar} {apellidoEliminar}";
        nombresYApellidosAEliminar.Add(nombreApellidoEliminar);
        telefonosAEliminar.Add(telefonoEliminar);
        correosAEliminar.Add(correoEliminar);
    }
}

// Crear la lista para guardar líneas de Limatambo.csv que no coinciden con los datos a eliminar
List<string> linesToKeep = new List<string>();

// Filtrar Limatambo.csv excluyendo personas en las listas de eliminación
foreach (string line in lines)
{
    string[] parts = line.Split(',');
    if (parts.Length > 14)
    {
        string nombre = parts[5].Trim();
        string apellido = parts[6].Trim();
        string telefono = parts[12].Trim();
        string correo = parts[14].Trim();
        string nombreApellido = $"{nombre} {apellido}";

        // Verificar si debe excluirse
        if (!nombresYApellidosAEliminar.Contains(nombreApellido) && 
            !telefonosAEliminar.Contains(telefono) && 
            !correosAEliminar.Contains(correo))
        {
            linesToKeep.Add(line);
        }
    }
}

// Escribir el archivo actualizado Limatambo-actualizado.csv
File.WriteAllLines(filenameActualizado, linesToKeep);
Console.WriteLine("Archivo 'Limatambo-actualizado.csv' creado con éxito.");

// Crear una lista para las líneas del archivo de eliminación con "X" al inicio de las eliminadas
List<string> linesEliminarMarcado = new List<string>();

// Marcar con "X" en Limatambo-eliminar.csv las personas que se eliminaron
foreach (string line in linesEliminar)
{
    string[] parts = line.Split(',');
    if (parts.Length > 7)
    {
        string nombreEliminar = parts[1].Trim();
        string apellidoEliminar = parts[2].Trim();
        string telefonoEliminar = parts[6].Trim();
        string correoEliminar = parts[7].Trim();

        string nombreApellidoEliminar = $"{nombreEliminar} {apellidoEliminar}";

        // Marcar con "X" si los datos coinciden con los que fueron eliminados en Limatambo.csv
        if (nombresYApellidosAEliminar.Contains(nombreApellidoEliminar) ||
            telefonosAEliminar.Contains(telefonoEliminar) ||
            correosAEliminar.Contains(correoEliminar))
        {
            linesEliminarMarcado.Add("X," + line); // Agregar "X" al inicio de la línea
        }
        else
        {
            linesEliminarMarcado.Add(line);
        }
    }
}

// Escribir el archivo marcado Limatambo-eliminar-marcado.csv
File.WriteAllLines(filenameEliminarMarcado, linesEliminarMarcado);
Console.WriteLine("Archivo 'Limatambo-eliminar-marcado.csv' creado con éxito, con 'X' para las personas eliminadas.");