using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lyweb2
{
    public static class tempData
    {
       public static List<Scenery> sceneries = new List<Scenery>();
       

        public static void CreateData()
        {
            sceneries.Add(new Scenery()
            {
                id = 1,
                name="Geneva",
                image="1.jpeg",
                description="Geneva is the second largest of Switzerland. In 2004,Geneva`s population is 185526 people",
                area="Europe"

            });
            sceneries.Add(new Scenery()
            {
                id = 2,
                name="Ukraine",
                image="2.jpeg",
                description="In Ukraine，National aviation museum is located in Kiev, near progenitor hani Airport(Zhulyany Airport), founded in 2003, for Ukraine's youngest museum, is also the largest museum about Ukraine aviation history and technology. ",
                area="Europe"

            });
            sceneries.Add(new Scenery()
            {
                id = 3,
                name="Guizhou",
                image="3.jpeg",
                description="Guizhou Province is located in the hinterland of the southwestern inland region and is a transportation hub in the southwestern region. It is an important component of the Yangtze River Economic Belt. ",
                area="Asia"

            });

            sceneries.Add(new Scenery()
            {
                id = 4,
                name="the Nile",
                image="4.jpeg",
                description="The Nile Valley keeps a temperate climate throughout the year.",
                area="Africa"

            });
            sceneries.Add(new Scenery()
            {
                id = 5,
                name="Bali",
                image="5.jpeg",
                description="In India and Bali students learn to vocalize music before ever picking up instruments.",
                area="Asia"

            });
            sceneries.Add(new Scenery()
            {
                id = 6,
                name="Auckland",
                image="6.jpeg",
                description="The winner will face the Oakland A's in the playoffs this weekend..",
                area="Australia;"

            });
        }

    }
}