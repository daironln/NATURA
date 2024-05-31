using UnityEngine;

namespace Questions
{
    public class QuestSystem : GenericSingleton<QuestSystem>
    {
        protected override void Awake()
        {
            base.Awake();
        }

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
                    "¿Cómo afecta el excesivo calor a los ecosistemas de la playa?",
                    "¿Cómo puede afectar el excesivo calor a los humanos en la playa?",
                    "¿Cómo podemos protegernos del excesivo calor en la playa?",

                }, 
                new []
                {   //2do Problema
                    "¿Por qué son un problema los residuos plásticos en las playas?",
                    "¿Cómo podemos reducir los residuos plásticos en las playas?",
                    "¿Qué se puede hacer con los residuos plásticos recogidos de las playas?",
                    
                }},
            new []{new [] //Artico
                {   //1er Problema
                    "¿Por qué están en peligro de extinción los osos polares?",
                    "¿Cómo afecta la extinción de los osos polares a los ecosistemas del Ártico?",
                    "¿Cómo podemos ayudar a proteger a los osos polares?",
                    
                }, 
                new []
                {   //2do Problema
                    "¿Por qué se están derritiendo los casquetes polares?",
                    "¿Cómo afecta el derretimiento de los casquetes polares al resto del mundo?",
                    "¿Cómo podemos reducir el derretimiento de los casquetes polares?",
                    
                }},
            new []{new [] //Bosque
                {   //1er Problema
                    "¿Por qué está disminuyendo la biodiversidad en los bosques?",
                    "¿Cómo afecta la pérdida de biodiversidad a los ecosistemas forestales?",
                    "¿Cómo podemos ayudar a proteger la biodiversidad en los bosques?",
                    
                }, 
                new []
                {   //2do Problema
                    "¿Por qué es un problema la deforestación?",
                    "¿Cómo podemos reducir la deforestación?",
                    "¿Qué efecto tiene la deforestación en el clima?",
                    
                }},
            new []{new [] //Desierto
                {   //1er Problema
                    "¿Por qué es un problema la sequía en los desiertos?",
                    "¿Cómo podemos adaptarnos a la sequía en los desiertos?",
                    "¿Cómo afecta la sequía a los ecosistemas del desierto?",
                    
                }, 
                new []
                {   //2do Problema
                    "¿Por qué es un problema la escasez de agua en los desiertos?",
                    "¿Cómo podemos adaptarnos a la escasez de agua en los desiertos?",
                    "¿Cómo afecta la escasez de agua a los ecosistemas del desierto?",
                    
                }}
            
        };
        
        private string[][][] badAnswers = {
            new []{new []//Ciudad
                {   //1er Problema

                    "Los árboles",
                    "Los edificios",   //1era Pregunta
                    "Los animales",
                    
                    "Mejora la visión",
                    "Aumenta la altura",   //2da Pregunta
                    "Energiza el cuerpo",
                    
                    "Construyendo más edificios",
                    "Usando más plástico",   //3ra Pregunta
                    "Tirando desechos",
                    
                }, 
                new []
                {   //2do Problema
                    
                    "Atrae a los turistas",
                    "Mejora el paisaje urbano",   //1era Pregunta
                    "Contribuye a mejorar la respiración",
                    
                    "Comprando más productos",
                    "Tirando la basura en la calle",   //2da Pregunta
                    "Evitando los contenedores de basura",
                    
                    "Se puede usar como ropa",
                    "Se puede usar para construir casas",   //3ra Pregunta
                    "Se puede jugar con ella",
                    
                }}, 
            new []{new [] //Playa
                {   //1er Problema
                    
                    "Hace que los peces crezcan más grandes",
                    "Hace que las olas sean mayores",   //1era Pregunta
                    "Hace que exista mucha más arena",
                    
                    "Mejora la visión nocturna",
                    "Aumenta la capacidad de correr rápido",   //2da Pregunta
                    "Permite crecer",
                    
                    "Comiendo mucha comida",
                    "Usando ropa de lana",   //3ra Pregunta
                    "Usando bufanda",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "Hacen que la arena sea más suave",
                    "Atraen a los peces",   //1era Pregunta
                    "Mejoran la belleza del paisaje",
                    
                    "Usando más plásticos",
                    "Tirando la basura en el océano",   //2da Pregunta
                    "Almacenando objetos",
                    
                    "Se pueden usar como alimento",
                    "Se pueden usar para hacer ropa",   //3ra Pregunta
                    "Se pueden volver a colocar en la arena",
                    
                }},
            new []{new [] //Artico
                {   //1er Problema
                     
                    "Están comiendo demasiado",
                    "No les gusta el frío",   //1era Pregunta
                    "Se aburren mucho",
                    
                    "Mejora la economía del Ártico",
                    "Hace que el hielo sea más fuerte",   //2da Pregunta
                    "Permite que se vea más hielo en el ecosistema",
                    
                    "Dándoles más comida",
                    "Llevándolos a los zoológicos",   //3ra Pregunta
                    "Haciendo que peleen entre ellos",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "Los osos polares están comiendo demasiado hielo",
                    "El Sol está más cerca del Ártico",   //1era Pregunta
                    "No se han explotado lo suficiente",
                    
                    "Hace que el agua del océano sea más salada",
                    "Crea más playas",   //2da Pregunta
                    "Hace que se equilibre el nivel del mar",
                    
                    "Usando más aire acondicionado",
                    "Comiendo más helado",   //3ra Pregunta
                    "Despilfarrando mucha agua",
                    
                }},
            new []{new [] //Bosque
                {   //1er Problema
                     
                    "Los árboles están creciendo demasiado rápido",
                    "Los animales están de vacaciones",   //1era Pregunta
                    "Para conservar los paisajes",
                    
                    "Hace que los bosques sean más bonitos",
                    "Aumenta la producción de oxígeno",   //2da Pregunta
                    "Hace que aparezcan más plantas",
                    
                    "Construyendo más edificios",
                    "Usando más papel",   //3ra Pregunta
                    "Cazando animales",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "Hace que los bosques sean más grandes",
                    "Aumenta la cantidad de árboles",   //1era Pregunta
                    "Ayuda a producir oxígeno",
                    
                    "Usando más papel",
                    "Cortando más arboles",   //2da Pregunta
                    "Botando desechos en los bosques",
                    
                    "Hace que llueva más",
                    "Crea más nubes",   //3ra Pregunta
                    "Permite que salga el Sol con frecuencia",
                }},
            new []{new [] //Desierto
                {   //1er Problema
                     
                    "Hace que los desiertos sean más extensos",
                    "Aumenta la cantidad de arena",   //1era Pregunta
                    "Permite que las especies convivan",
                    
                    "Usando más agua",
                    "Destruyendo el suelo manualmente",   //2da Pregunta
                    "Plantando más árboles",
                    
                    "Crea más dunas de arena",
                    "Permite que aparezcan nuevaas plantas",   //3ra Pregunta
                    "Hace que los animales aumenten su tamaño",
                }, 
                new []
                {   //2do Problema
                     
                    "Aumenta la cantidad de arena",
                    "Hace que los desiertos sean verdes",   //1era Pregunta
                    "Permite que las personas puedan saciar su sed",
                    
                    "Plantando más árboles",
                    "Explotando los suelos",   //2da Pregunta
                    "Usando más agua",
                    
                    "Crea más arena",
                    "Hace que aparezcan más animales",   //3ra Pregunta
                    "Atrae a los visitantes",
                }}
            
        };
        
        private string[][][] correctAnswers = {
            new []{new []//Ciudad
                {   //1er Problema
                    
                    "Los vehículos de motor",
                    "Los desechos de las fábricas",   //1era Pregunta
                    "Los residuos tóxicos",
                    
                    "Puede causar enfermedades respiratorias",
                    "Puede empeorar la visión en general",   //2da Pregunta
                    "Puede causar irritaciones",
                    
                    "Usando más transporte público",
                    "Empleando transportes a base de electricidad",   //3ra Pregunta
                    "Evitando vehículos que usen combustibles pesados",
                    
                }, 
                new []
                {   //2do Problema
                    
                    "Puede causar problemas de salud",
                    "Puede causar contaminación",   //1era Pregunta
                    "Es un vertedero seguro de animales peligrosos",
                    
                    "Reciclando",
                    "Reutilizando en vez de tirar",   //2da Pregunta
                    "Evitando las compras innecesarias",
                    
                    "Se puede compostar para crear abono",
                    "Se puede usar como alimento para animales de granja",   //3ra Pregunta
                    "Se puede usar en biogás",
                    
                }}, 
            new []{new [] //Playa
                {   //1er Problema
                    
                    "Puede causar la muerte de especies marinas sensibles al calor",
                    "Puede hacer desaparecer especies de plantas marinas",   //1era Pregunta
                    "Puede desequilibrar las relaciones animales",
                    
                    "Puede causar deshidratación",
                    "Puede ocasionar golpes de calor",   //2da Pregunta
                    "Puede alterar el estado de ánimo",
                    
                    "Usando protector solar",
                    "Bebiendo mucha agua",   //3ra Pregunta
                    "Empleando ropas frescas y protectoras",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "Puede dañar la vida marina en general",
                    "Puede contaminar el agua",   //1era Pregunta
                    "Pueden condenar la vida de los animales acuáticos",
                    
                    "Recogiendo cualquier basura que veamos",
                    "Evitando comprar en el lugar",   //2da Pregunta
                    "Trayendo de vuelta toda aquella basura que generemos",
                    
                    "Se pueden reciclar para hacer nuevos productos",
                    "Se pueden producir envases",   //3ra Pregunta
                    "Se pueden emplear en embalajes",
                    
                }},
            new []{new [] //Artico
                {   //1er Problema
                     
                    "El calentamiento global está derritiendo el hielo del Ártico, su hábitat natural",
                    "Por la interacción como parte de investigaciones humanas",   //1era Pregunta
                    "Por los conflictos naturales a raíz del cambio climático",
                    
                    "Puede desequilibrar la cadena alimentaria",
                    "Puede afectar a otras especies",   //2da Pregunta
                    "Estaría desapareciendo una parte importante del ecosistema",
                    
                    "Reduciendo nuestras emisiones de gases de efecto invernadero",
                    "Reduciendo el conflicto con las personas",   //3ra Pregunta
                    "Reduciendo los impactos industriales",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "El calentamiento global está aumentando las temperaturas del Ártico",
                    "El cambio climático desequilibra las temperaturas",   //1era Pregunta
                    "Los agujeros en la capa de ozono cada vez son más grandes",
                    
                    "Puede causar aumento en el nivel del mar",
                    "Puede causar inundaciones costeras",   //2da Pregunta
                    "Aumenta la probabilidad de tsunamis",
                    
                    "Reduciendo nuestras emisiones de gases de efecto invernadero",
                    "Evitando la apertura de industrias innecesarias",   //3ra Pregunta
                    "Conservando la naturaleza mediante energías renovables",
                    
                }},
            new []{new [] //Bosque
                {   //1er Problema

                    "La deforestación y el cambio climático están destruyendo los hábitats",
                    "Los animales no se sienten seguros en entornos tan destruidos",   //1era Pregunta
                    "La acción del hombre deteriora los elementos naturales",
                    
                    "Puede desequilibrar la cadena alimentaria",
                    "Puede afectar a todas las especies del bosque",   //2da Pregunta
                    "Rompe con las relaciones en el ecosistema",
                    
                    "Protegiendo los hábitats",
                    "Reduciendo la deforestación",   //3ra Pregunta
                    "Evitando los daños intencionados a las especies",
                    
                }, 
                new []
                {   //2do Problema
                     
                    "Destruye los hábitats",
                    "Contribuye al cambio climático",   //1era Pregunta
                    "Contribuye al calentamiento global",
                    
                    "Usando productos de madera de forma sostenible",
                    "Protegiendo los bosques",   //2da Pregunta
                    "Evitando la tala de árboles frecuente sin sembrar nada a cambio",
                    
                    "Aumenta las emisiones de CO2, gas de efecto invernadero",
                    "Aumenta el grado de calor anormal",   //3ra Pregunta
                    "Aumenta la probabilidad de sequías e incendios",
                }},
            new []{new [] //Desierto
                {   //1er Problema
                     
                    "Puede causar escasez de agua",
                    "Dificulta la vida en estas áreas",   //1era Pregunta
                    "Aumenta el nivel de la temperatura promedio",
                    
                    "Usando técnicas de conservación de agua",
                    "Sembrando plantas resistentes a las sequías",   //2da Pregunta
                    "Llevando elementos para asegurar nuestra estancia en el lugar",
                    
                    "Puede causar la muerte de plantas",
                    "Puede causar la muerte de animales que dependen del agua",   //3ra Pregunta
                    "Puede extinguir especies particulares y exóticas",
                }, 
                new []
                {   //2do Problema
                     
                    "Puede dificultar la vida de las personas",
                    "Puede dificultar la vida de los animales en estas áreas",   //1era Pregunta
                    "Puede contribuir a aumentar el calor",
                    
                    "Consumiento botellas de agua con antelación",
                    "Usando técnicas para conservar el agua",   //2da Pregunta
                    "Protegiéndonos del cansancio y el agotamiento",
                    
                    "Puede provocar la desaparición de especies presentes",
                    "Pueden extinguirse especies en favor del desierto",   //3ra Pregunta
                    "Puede contribuir al aumento de la temperatura promedio",
                }}
            
        };

        public (string, int) getQuestion(int escen, int probl)
        {
            var r = Random.Range(0, 3);
            return (questions[escen][probl][r], r);
        }
        public (string, int) getBadAnswer(int escen, int probl, int ans, int nonElegible)
        {
            int r;
            int c;
            
            do
            {
                r = Random.Range(0, 3);
                c = (ans * 3) + r;
            } 
            while (c == nonElegible);
            
            return (badAnswers[escen][probl][c], c);
        }
        
        public string getCorrectAnswer(int escen, int probl, int ans)
        {
            var r = Random.Range(0, 3);
            var c = (ans * 3) + r;
            return correctAnswers[escen][probl][c];
        }
    }
}