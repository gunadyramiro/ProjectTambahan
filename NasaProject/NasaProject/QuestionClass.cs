using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaProject
{

    class QuestionClass
    {
        private int questionnumber;
        private string mode;
        private string question;
        private string answera;
        private string answerb;
        private string answerc;
        private string answerd;
        private string realanswer;
        private string fact;
        private int score;


        public int QuestionNumber
        {
            get
            {
                return questionnumber;
            }
            set
            {
                questionnumber=value;
            }
        }

        public string Mode
        {
            get
            {
                return mode;
            }
            set
            {
                mode = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }

        public string AnswerA
        {
            get
            {
                return answera;
            }
            set
            {
                answera = value;
            }
        }

        public string AnswerB
        {
            get
            {
                return answerb;
            }
            set
            {
                answerb = value;
            }
        }

        public string AnswerC
        {
            get
            {
                return answerc;
            }
            set
            {
                answerc = value;
            }
        }

        public string AnswerD
        {
            get
            {
                return answerd;
            }
            set
            {
                answerd = value;
            }
        }

        public string RealAnswer
        {
            get
            {
                return realanswer;
            }
            set
            {
                realanswer = value;
            }
        }

        public string Fact
        {
            get
            {
                return fact;
            }
            set
            {
                fact = value;
            }
        }

        private string[,] beginnerquestion =new string[10,6] {
                                            {"Earth rotates in about _____ hours","12", "24", "6", "26", "24"},
                                            {"The Earth is the ______ planet from the Sun.", "Fifth", "Fourth", "Third", "Second", "Third"},
                                            {"The highest mountain on the Earth, measured conventionally from sea level, is _________", "Mauna Kea", "K2", "Everest", "McKinley", "Everest"},
                                            {"What is the name of the largest ocean on Earth?", "Pacific Ocean", "Atlantic Ocean", "Indian Ocean", "Arctic Ocean", "Pacific Ocean"},
                                            {"What is the name of the largest river?", "The Amazon", "The Misssissippi", "The Nile", "The Ganges", "The Nile"},
                                            {"Outside of Antarctica, what is the largest desert in the world?","Kalahari Desert","Sahara Desert","Arabian Desert","Great Victoria Desert", "Sahara Desert"},
                                            {"70 percent of the Earth is covered with:","Water","Rock","Dessert","Ice", "Water"},
                                            {"Size-wise the Earth ranks:","Fifth largest","Smallest","Largest","Third largest", "Fifth largest"},
                                            {"What gas other than nitrogen is in our atmosphere?","Neon","Radon","Oxygen","Hydrogen", "Oxygen"},
                                            {"What percentage of nitrogen is in our atmosphere?","78%","55%","3%","19%", "3%"}};

        private string[,] intermediatequestion = new string[10, 6]{
                                                  {"Movement of the earth on its axis is called as _______.","Resolution","Cycle","Revolution","Rotation","Rotation"},
                                                  {"We can see Full moon once a month and that night is called as _______.", "Poornima", "Half Amavasy", " Half Poornim", "Amavasya", "Poornima"},
                                                  {"In ancient times, people used to determine directions during the night with the help of ______.", "Constellations", "Planets", "Stars", "Pole", "Stars"},
                                                  {"The ____ is in the centre of the solar system.", "Jupiter", "Venus", "Earth", "Sun", "Sun"},
                                                  {"Our solar system is a part of ________ galaxy.", "Pinwheel Galaxy", "Milky Way", " Cigar Galaxy", "Bode's Galaxy", "Milky Way"},
                                                  {"Neil Armstrong step on the surface of the moon on __________.", "29 July 1969","29 July 1949", "29 July 1979", "29 July 1959","29 July 1969"},
                                                  {"The value of the prime meridian is ________ degree.", "0", "90", "180", "270", "0"},
                                                  {"The diameter of earth is approximately ________", "6400 km", "4600 km", "12800 km", " 12800 km", "12800 km"},
                                                  {"Third layer of Earth which comes after Mantle of Earth is known as _______", "The Outer Core", "The Inner Core", "The Mantle", "The Crust", "The Outer Core"},
                                                  {"Two halves in which Earth is divided are called _______", "ridges", "trenches", "equators", "hemispheres", "trenches"} };

        private string[,] expertquestion = new string[10, 6]{
                                           {"Alps Mountains and Himalayas are classic example of process of ______", "Plate Owning", "Plate Tectonics", "Plate Convection", "Folding", "Folding"},
                                           {"Lowest part of mantle is known as", "A-layer", "B-layer", "M-layer", "D-layer", "D-layer"},
                                           {"What is the angle of inclination of Earth’s Axis to its orbital plane?", "66.5 Degree", "66.25 Degree", "23.5 Degree", "90 Degree", "66.5 Degree"},
                                           {"When does the spring tide occur ?", "Moon is nearest to Earth", "Moon is farthest to Earth", "Moon sun and earth are perpendicular to each other", "Sun moon and earth are colinear", "Sun moon and earth are colinear"},
                                           {"Where does the speed of rotation of Earth is highest?", "Along Equator", "At Both pole (North and South Pole)", "At Tropic cancer", "at Arctic Circle", "Along Equator"},
                                           {"Degree of hardness of Minerals is measured by which of the following scale?", "Litho Scale", "Mohs’ Scale", "Aesthono Scale", "Sima Sclae", "Mohs’ Scale"},
                                           {"What is the total surface of the earth?", "510 million square kilometer", "610 million square kilometer", "710 million square kilometer", "810 million square kilometer", "510 million square kilometer"},
                                           {"On 22nd Dec, where does the day is longest and night is shortest?", "Beijing", "Melbourne", "Washington DC", "Chennai", "Melbourne"},
                                           {"The height from the earth of Geostationary orbit is situated is ______", "36000 km", "62000 km", "22000 km", "43000 km", "36000"},
                                           {"If moon is seen in a particular place on the sky at 6:48 p.m. When it will be seen on the same place on the sky after 4 days?", "At 10 PM", "At 10:48 PM", "At 9:28 PM", "At 8:30 PM", "At 10 PM"}};

        private string[] funfact = new string[10]{"The temperature of Earth’s core is estimated at 6,000 °C (about 10,800 °F). That’s as hot as the surface of the sun.",
                                    "Earth’s atmosphere is composed of 78% nitrogen, 21% oxygen, and trace amounts of other gases including argon and carbon dixoide.",
                                    "Earth orbits the sun once every 365.25 days. Since our calendar years have only 365 days, we add an extra leap day every four years to account for the difference.",
                                    "Earth is the planet we have the best opportunity to understand in detail—helping us see how other rocky planets behave, even those orbiting distant stars. As a result, scientists are increasingly monitoring Earth from space. NASA alone has dozens of missions dedicated to solving our planet's mysteries.",
                                    "We are all traveling around the Sun at an average velocity of 107,182 kilometers per hour.",
                                    "It is estimated that life came to existence on Earth some 4.1 billion years ago.",
                                    "Based on the Astronauts first went into space observations, the Earth acquired the nickname the “Blue Planet:. And it’s no surprise, seeing as how 70% of our planet is covered with oceans. The remaining 30% is the solid crust that is located above sea level, hence why it is called the “continental crust”",
                                    "It actually takes 23 hours, 56 minutes and 4 seconds for the Earth to rotate once completely on its axis, which astronomers refer to as a Sidereal Day. Now wait a second, doesn’t that mean that a day is 4 minutes shorter than we think it is?",
                                    "Scientists have recently estimated that an ocean of water exists at a distance of 1,000 km under the surface of the Earth. And this water is important for volcanic activity, which in turn is responsible for generating soil.",
                                    "There are more than 100 million pieces of junk orbiting Earth at about 17,000 miles per hour hour (27,000 km/hr)."};


        public void BeginnerLevel(int qnumber)
        {
            QuestionNumber = qnumber;
            if (qnumber <= 10)
            {
                Question = beginnerquestion[qnumber-1,0];
                AnswerA = beginnerquestion[qnumber-1,1];
                AnswerB = beginnerquestion[qnumber-1,2];
                AnswerC = beginnerquestion[qnumber-1,3];
                AnswerD = beginnerquestion[qnumber-1,4];
                RealAnswer = beginnerquestion[qnumber-1,5];
            }
            else
            {

            }
        }

        public void IntermediateLevel(int qnumber)
        {
            QuestionNumber = qnumber;
            if (qnumber <= 10)
            {
                Question = intermediatequestion[qnumber-1, 0];
                AnswerA = intermediatequestion[qnumber-1, 1];
                AnswerB = intermediatequestion[qnumber-1, 2];
                AnswerC = intermediatequestion[qnumber-1, 3];
                AnswerD = intermediatequestion[qnumber-1, 4];
                RealAnswer = intermediatequestion[qnumber-1, 5];
            }
        }

        public void ExpertLevel(int qnumber)
        {
            QuestionNumber = qnumber;
            if (qnumber <= 10)
            {
                Question = expertquestion[qnumber-1, 0];
                AnswerA = expertquestion[qnumber-1, 1];
                AnswerB = expertquestion[qnumber-1, 2];
                AnswerC = expertquestion[qnumber-1, 3];
                AnswerD = expertquestion[qnumber-1, 4];
                RealAnswer = expertquestion[qnumber-1, 5];
            }
        }

        public void BeginnerCheckAnswer(string ans)
        {
            if (ans == RealAnswer)
            {
                Score = Score +10;
                MessageBox.Show("Your answer is Correct! ","Answer Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("SYour answer is Wrong!\nThe correct answer is "+RealAnswer, "Answer Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void IntermediaterCheckAnswer(string ans)
        {
            if (ans == RealAnswer)
            {
                Score = Score + 10;
                MessageBox.Show("Your answer is Correct! ", "Answer Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your answer is Wrong!\nThe correct answer is " + RealAnswer, "Answer Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
         }

        public void ExpertCheckAnswer(string ans)
        {
            if (ans == RealAnswer)
            {
                Score = Score + 10;
                MessageBox.Show("Your answer is Correct! ","Answer Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your answer is Wrong!\nThe correct answer is "+ RealAnswer, "Answer Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public String RandomFact()
        {
            Random randomize = new Random();
            int index = randomize.Next(funfact.Length);
            return funfact[index];
        }
    }
}
