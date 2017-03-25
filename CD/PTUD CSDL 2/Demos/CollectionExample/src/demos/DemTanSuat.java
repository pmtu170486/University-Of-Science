/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demos;

import java.util.HashSet;
import java.util.Iterator;
import java.util.Scanner;
import java.util.Set;

/**
 *
 * @author home
 */
public class DemTanSuat {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.printf("Nhap chuoi: ");
        String str = sc.nextLine();
        // Chuyen chuoi ve mang cac ki tu
        char[] arr = str.toCharArray();
        // Dem so luong ki tu
        MyCharacter mychar;
        Set<MyCharacter> data=new HashSet<MyCharacter>();
        for (int i = 0; i < arr.length; i++) {
            mychar = new MyCharacter();
            mychar.setKitu(arr[i]);
            mychar.setTansuat(tansuat(arr, arr[i]));
            data.add(mychar);
        }
        xuat(data);        
    }

    public static int tansuat(char[] arr, char c) {
        int dem = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == c) {
                dem++;
            }
        }
        return dem;
    }

    public static void xuat(Set<MyCharacter> hs) {
        for (Iterator<MyCharacter> it = hs.iterator(); it.hasNext();) {
            MyCharacter myCharacter = it.next();
            System.out.printf("%n%c : %d", myCharacter.getKitu(), myCharacter.getTansuat());
        }
    }
}
