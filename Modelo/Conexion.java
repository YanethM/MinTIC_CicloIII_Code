package Modelo;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;


public class Conexion {
    //1. Crear la instancia de la clase Connection del JAR JDBC
    Connection connection;
    
    //2. Añadimos el constructor de la clase sin argumentos

    public Conexion() {
        //3. Intentar hacer conexión con la base de datos desde el constructor de la clase
        //Intentar hacer algo...
        try {
            //4. Buscamos la clase dentro JAR que coincide con este nombre com.mysql.cj.jdbc.Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //5. Llamamos la instancia connection a la cual le enviamos los parametros
            //de conexión con la base de datos (cadena de conexiòn, usuario, contraseña)
            connection= DriverManager.getConnection("jdbc:mysql://localhost:3303/reto1_g56_db", "root", "");
            if(connection != null){
                System.out.println("Conexión exitosa");
            }
        } catch (ClassNotFoundException | SQLException e) {
            System.out.println("Conexión fallida");
        }
    }
    
    //6. Creamos una función que retorn la Connection de la clase
    public Connection getConnection(){
        return connection;
    }
    
}
