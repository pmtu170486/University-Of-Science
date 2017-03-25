/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demos;

/**
 *
 * @author home
 */
public class MyCharacter {

    private char kitu;
    private int tansuat;

    public char getKitu() {
        return kitu;
    }

    public void setKitu(char kitu) {
        this.kitu = kitu;
    }

    public int getTansuat() {
        return tansuat;
    }

    public void setTansuat(int tansuat) {
        this.tansuat = tansuat;
    }

    @Override
    public boolean equals(Object obj) {
        return kitu== ((MyCharacter)obj).kitu; //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int hashCode() {
        return kitu; //To change body of generated methods, choose Tools | Templates.
    }

  
}
