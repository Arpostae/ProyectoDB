Imports System.Data.SqlClient

Module Module1
    Sub Main()
        ' Cadena de conexión
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=Restaurante;Integrated Security=True;"

        ' Objeto de conexión
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abrir conexión
                connection.Open()
                Console.WriteLine("Conexión exitosa.")

                ' Crear un comando SQL
                Dim query As String = "SELECT * FROM Usuarios"
                Dim command As New SqlCommand(query, connection)

                ' Leer los datos
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Console.WriteLine($"ID: {reader("ID")}, Nombre: {reader("Nombre")}")
                End While

            Catch ex As Exception
                Console.WriteLine($"Error: {ex.Message}")
            End Try
        End Using

        ' Mantener consola abierta
        Console.ReadLine()
    End Sub
End Module
