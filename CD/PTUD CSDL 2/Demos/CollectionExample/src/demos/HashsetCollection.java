/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package demos;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.Iterator;
import java.util.List;
import java.util.Scanner;
import java.util.Set;

/**
 *
 * @author home
 */
public class HashsetCollection {
    
    public static void main(String[] args) {
        List<String> hs=new ArrayList();
        int i=1;
        do
        {
            System.out.println("Nhap ten: ");
            hs.add(new Scanner(System.in).nextLine());
        }while(++i<=5);
        System.out.println("Nhap ten can tim kiem: ");
        String name=new Scanner(System.in).nextLine();
        
        if(hs.contains(name))
            System.out.println("Ten tim thay");
        else
            System.out.println("Ten khong tim thay");
    }
}
