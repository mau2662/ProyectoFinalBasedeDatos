
package com.hospital.dao;

import com.hospital.entity.Cliente;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import javax.swing.JTable;


public class ClienteDAO {

    private String mensaje = "";

    public String agregarCliente(Connection con, Cliente cli) {
        PreparedStatement pst = null;
        String sql = "INSERT INTO GENERICO.CLIENTE VALUES(3,?,?,?,?,?,?)";

        try {
            pst = con.prepareStatement(sql);
            pst.setString(1, cli.getNombre());
            pst.setString(2, cli.getApellido());
            pst.setString(3, cli.getGenero());
            pst.setString(4, cli.getCorreo());
            pst.setString(5, cli.getDireccion());
            pst.setInt(6, cli.getTelefono());
            mensaje = "Guardado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Guardar Correctamente \n " + e.getMessage();

        }

        return mensaje;
    }

    public String modificarCliente(Connection con, Cliente cli) {
        PreparedStatement pst = null;
        String sql = "UPDATE GENERICO.CLIENTE SET NOMBRE= ?, APELLIDO =?, GENERO=?, CORREO =?, DIRECCION =?,TELEFONO =? "
                + "WHERE ID_CLIENTE =?";

        try {
            pst = con.prepareStatement(sql);
            pst.setString(1, cli.getNombre());
            pst.setString(2, cli.getApellido());
            pst.setString(3, cli.getGenero());
            pst.setString(4, cli.getCorreo());
            pst.setString(5, cli.getDireccion());
            pst.setInt(6, cli.getTelefono());
            pst.setInt(7, cli.getId_Cliente());
            mensaje = "Modificado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo Actualizar Correctamente \n " + e.getMessage();

        }

        return mensaje;

    }

    public String eliminarCliente(Connection con, int id) {

        PreparedStatement pst = null;
        String sql = "DELETE FROM CLIENTE WHERE ID_CLIENTE =?";

        try {
            pst = con.prepareStatement(sql);
            pst.setInt(1, id);
            mensaje = "Eliminado Correctamente";
            pst.execute();
            pst.close();

        } catch (SQLException e) {

            mensaje = "No se pudo eliminar Correctamente \n " + e.getMessage();

        }
        return mensaje;

    }

    public void listarCliente(Connection con, JTable tabla) {

    }

}
