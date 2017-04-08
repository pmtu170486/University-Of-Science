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
public abstract class Shape {
    protected float width;
    protected float height;
    public float getWidth() {
        return width;
    }
    public void setWidth(float width) {
        this.width = width;
    }

    public float getHeight() {
        return height;
    }

    public void setHeight(float height) {
        this.height = height;
    }
    public abstract float dientich();
    
    public void xuat(){
        System.out.printf("%f:%f",width,height);
    }    
}
