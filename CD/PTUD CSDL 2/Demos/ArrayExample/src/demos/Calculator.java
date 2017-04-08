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
public class Calculator {
    
    public int add(int a,int b){
        return a+b;
    }
    public float add(float a,float b){
        return a+b;
    }
    public int add(int []a){
        int sum = 0;
        for(int i=0;i<a.length;i++){
            sum=sum+a[i];            
        }
        return sum;
    }
            
}
