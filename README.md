# Epidemify

## Objetivo

Mantener la epidemia el mayor tiempo posible.

## Idea

Sumar la mayor cantidad de puntos (cantidad de infectados por tiempo). Se pierde cuando algún medico nos cura a nosotros (que somos la raíz de la epidemia). 
La idea es un escenario (plaza, o lo que sea no importa) en donde comienza con un infectado (aleatorio entre las personas) y el infectado es quien manejamos nosotros tratando de infectar a todos los que estan a nuestro alrededor (con estornudos, mocos). A medida que pasa el tiempo van apareciendo cada vez más médicos que van curando a quienes están infectados por nosotros logrando así que sumemos menos puntos. Los médicos no pueden ser infectados.

**Constraints y dificultades:**

- Si se infecta 2 veces a la misma persona, muere. (Lo que conlleva a sumar menos puntos por tiempo)

- Se van agregando médicos a medida que pasa el tiempo (en algún punto nos tienen que curar :P)

- Cada X tiempo aparece un item (o algo) que al recolectarlo convierte a los médicos en vulnerables también y podemos infectarlos también (al estilo pacman). Es decir, se podría poner todo en negativo (filtro) una risa macabra y empezar a perseguir los medicos que deberían alejarse de nosotros. 

- Cada X tiempo podría caer una “bomba” (o algo) que cuando explota libera una cura en un radio pequeño.
