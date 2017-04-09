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
public interface TimeClient {
     int hour=0;
     int minute=0;
     int second=0;
     public void setTime(int hour,int minute, int second);
     public void increaseHour(int hour);
     public void decreaseHour(int hour);     
}
