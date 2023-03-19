/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.hospital.test;

import com.hospital.bo.EmpleadoBO;
import com.hospital.entity.Empleado;

/**
 *
 * @author varga
 */
public class Test {

    EmpleadoBO ebo = new EmpleadoBO();
    Empleado emp = new Empleado();
    String mensaje = "";

    public void insertar() {
        emp.setNombre("Allan");
        emp.setApellido("Perez");
        emp.setCorreo("allan@");
        emp.setFecha_Contratacion("13-02");
        emp.setTelefono("548541");
        emp.setSalario(200);
        mensaje = ebo.agregarEmpleado(emp);
        System.out.println(mensaje);
    }

    public void modificar() {
        emp.setId_Empleado(3);
        emp.setNombre("Ale");
        emp.setApellido("Rojas");
        emp.setCorreo("ale@");
        emp.setFecha_Contratacion("13-02");
        emp.setTelefono("548541");
        emp.setSalario(100);
        mensaje = ebo.modificarEmpleado(emp);
        System.out.println(mensaje);
    }
    
       public void eliminar() {
                mensaje = ebo.eliminarEmpleado(5);
        System.out.println(mensaje);
    }

    public static void main(String[] args) {
        Test test = new Test();
     // test.insertar();
       // test.modificar();
       test.eliminar();
    }

}
