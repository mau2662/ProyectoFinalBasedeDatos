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
        emp.setNombre("Jenny");
        emp.setApellido("Rrojas");
        emp.setCorreo("Jenny@");
        emp.setSalario(500);
        emp.setTelefono("8969315");
        mensaje = ebo.agregarEmpleado(emp);
        System.out.println(mensaje);
    }

    public static void main(String[] args) {
        Test test = new Test();
        test.insertar();
    }
    
}
