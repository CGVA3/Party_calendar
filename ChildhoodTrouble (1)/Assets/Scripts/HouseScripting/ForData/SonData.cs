using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SonData
{
        int dataSocialGroup;
        int dataSports;
        int dataMusic;
        int dataFood;
        int tension;
        public SonData(int dataSocialGroup, int dataSports, int dataMusic, int dataFood, int tension)
        {
            this.dataSocialGroup = dataSocialGroup;
            this.dataSports = dataSports;
            this.dataMusic = dataMusic;
            this.dataFood = dataFood;
            this.tension = tension;

        }
        public SonData(SonData atr)
        {
            this.dataSocialGroup = atr.dataSocialGroup;
            this.dataSports = atr.dataSports;
            this.dataMusic = atr.dataMusic;
            this.dataFood = atr.dataFood;
            this.tension = atr.tension;
        }

        public SonData(sonAtributes atr)
        {
        this.dataSocialGroup = atr.Social;
        this.dataSports = atr.Sport;
        this.dataMusic = atr.Music;
        this.dataFood = atr.Food;
        this.tension = atr.Tension;


    }
        public void setSocial(int Social)
        {
            dataSocialGroup = Social;

        }
        public void setSport(int Sport)
        {
            dataSports = Sport;

        }
        public void setMusic(int Music)
        {
            dataMusic = Music;
        }
        public void setTension(int Tension)
        {
            tension = Tension;
        }
        public void setFood(int Food)
        {
            dataFood = Food;
        }
        //get
        public int getSocial()
        {
            return dataSocialGroup;

        }
        public int getSport()
        {
            return dataSports;

        }
        public int getMusic()
        {
            return dataMusic;
        }
        public int getTension()
        {
            return tension;
        }
        public int getFood()
        {
            return dataFood;
        }
    }
