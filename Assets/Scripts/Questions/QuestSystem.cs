using UnityEngine;

namespace Questions
{
    public class QuestSystem
    {
        private string[][][] questions = {
            new []{new []//Ciudad
                {   //1er Problema
                    "¿Cuál es la principal fuente de contaminación en las ciudades?",
                    "¿Qué efecto tiene la contaminación del aire en la salud humana?",
                    "¿Cómo podemos reducir la contaminación en las ciudades?"
                    
                }, 
                new []
                {   //2do Problema
                    "¿Por qué es un problema la acumulación de basura en las ciudades?",
                    "¿Cómo podemos reducir la cantidad de basura que producimos?",
                    "¿Qué se puede hacer con la basura orgánica?",
                    
                }}, 
            new []{new [] //Playa
                {   //1er Problema
                    "",
                    "",
                    "",
                    
                }, 
                new []
                {   //2do Problema
                    "",
                    "",
                    "",
                    
                }},
            new []{new [] //Artico
                {   //1er Problema
                    "",
                    "",
                    "",
                    
                }, 
                new []
                {   //2do Problema
                    "",
                    "",
                    "",
                    
                }},
            new []{new [] //Bozque
                {   //1er Problema
                    "",
                    "",
                    "",
                    
                }, 
                new []
                {   //2do Problema
                    "",
                    "",
                    "",
                    
                }},
            new []{new [] //Desierto
                {   //1er Problema
                    "",
                    "",
                    "",
                    
                }, 
                new []
                {   //2do Problema
                    "",
                    "",
                    "",
                    
                }}
            
        };
        
        private string[][][] badAnswers = {
            new []{new []//Ciudad
                {   //1er Problema
                    
                    "Los árboles",
                    "Los edificios",   //1era Pregunta
                    "Los animales?",
                    
                    "Mejora la visión",
                    "Aumenta la altura",   //2da Pregunta
                    "Ninguno",
                    
                    "Plantando más edificios",
                    "Usando más plástico",   //3ra Pregunta
                    "Tirando desechos",
                    
                }, 
                new []
                {   //2do Problema
                    
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }}, 
            new []{new [] //Playa
                {   //1er Problema
                    
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }},
            new []{new [] //Artico
                {   //1er Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }},
            new []{new [] //Bozque
                {   //1er Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                }},
            new []{new [] //Desierto
                {   //1er Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                }}
            
        };
        
        private string[][][] correctAnswers = {
            new []{new []//Ciudad
                {   //1er Problema
                    
                    "Los vehículos de motor",
                    "Los desechos de las fabricas",   //1era Pregunta
                    "Los residuos tóxicos",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                    
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }}, 
            new []{new [] //Playa
                {   //1er Problema
                    
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }},
            new []{new [] //Artico
                {   //1er Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }},
            new []{new [] //Bozque
                {   //1er Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                }},
            new []{new [] //Desierto
                {   //1er Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                }, 
                new []
                {   //2do Problema
                     
                    "",
                    "",   //1era Pregunta
                    "",
                    
                    "",
                    "",   //2da Pregunta
                    "",
                    
                    "",
                    "",   //3ra Pregunta
                    "",
                }}
            
        };

        public (string, int) getQuestion(int escen, int probl)
        {
            var r = Random.Range(0, 2);
            return (questions[escen][probl][r], r);
        }
        public string getBadAnswer(int escen, int probl, int ans)
        {
            var r = Random.Range(0, 2);
            var c = (ans * 3) + r;
            return badAnswers[escen][probl][c];
        }
        
        public string getCorrectAnswer(int escen, int probl, int ans)
        {
            var r = Random.Range(0, 2);
            var c = (ans * 3) + r;
            return correctAnswers[escen][probl][c];
        }
    }
}
