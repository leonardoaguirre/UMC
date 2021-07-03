/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author alunocmc
 */
public class AlunoTest {
    
    public AlunoTest() {
    }
    
    @BeforeClass
    public static void setUpClass() {
    }
    
    @AfterClass
    public static void tearDownClass() {
    }
    
    @Before
    public void setUp() {
    }
    
    @After
    public void tearDown() {
    }

    /**
     * Test of getRgm method, of class Aluno.
     */
    @Test
    public void testGetRgm() {
        System.out.println("getRgm");
        Aluno instance = new Aluno();
        int expResult = 0;
        int result = instance.getRgm();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setRgm method, of class Aluno.
     */
    @Test
    public void testSetRgm() {
        System.out.println("setRgm");
        int rgm = 0;
        Aluno instance = new Aluno();
        instance.setRgm(rgm);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getNome method, of class Aluno.
     */
    @Test
    public void testGetNome() {
        System.out.println("getNome");
        Aluno instance = new Aluno();
        String expResult = "";
        String result = instance.getNome();
        assertEquals(expResult, result);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setNome method, of class Aluno.
     */
    @Test
    public void testSetNome() {
        System.out.println("setNome");
        String nome = "";
        Aluno instance = new Aluno();
        instance.setNome(nome);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getNota1 method, of class Aluno.
     */
    @Test
    public void testGetNota1() {
        System.out.println("getNota1");
        Aluno instance = new Aluno();
        double expResult = 0.0;
        double result = instance.getNota1();
        assertEquals(expResult, result, 0.0);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setNota1 method, of class Aluno.
     */
    @Test
    public void testSetNota1() {
        System.out.println("setNota1");
        double nota1 = 0.0;
        Aluno instance = new Aluno();
        instance.setNota1(nota1);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of getNota2 method, of class Aluno.
     */
    @Test
    public void testGetNota2() {
        System.out.println("getNota2");
        Aluno instance = new Aluno();
        double expResult = 0.0;
        double result = instance.getNota2();
        assertEquals(expResult, result, 0.0);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }

    /**
     * Test of setNota2 method, of class Aluno.
     */
    @Test
    public void testSetNota2() {
        System.out.println("setNota2");
        double nota2 = 0.0;
        Aluno instance = new Aluno();
        instance.setNota2(nota2);
        // TODO review the generated test code and remove the default call to fail.
        fail("The test case is a prototype.");
    }
    
}
