# Sprites
1. Agregar el atlas de sprites del personaje a la escena. Configurar el sprite como múltiple y subdividirlo para tener acceso a los sprites para generar las animaciones. Agregar una de las imágenes a la escena.

![ej1_1](imgs/ej1_1.png)

![ej1_2](imgs/ej1_2.png)

2. Creamos un objeto 2D, arrastrando un conjunto de imágenes que selecciones al objeto añadiremos una animación. Agregar al personaje la animación “Walk Down”. Añadir otra imagen y generarle otra animación.  De esa forma Unity crea un objeto Animation, la primera vez que se crea, también añade un objeto Animator Controller.

![ej2_1](imgs/ej2_1.png)

![ej2_2](imgs/ej2_2.png)

![ej2](imgs/ej2.gif)

3. Creamos los scripts para controlar el movimiento para el personaje. Inicialmente vamos a hacer una versión sin salto. Añadir los scripts necesarios para moverlo por la pantalla. En este caso sólo tendremos que mover las coordenadas (X, Y).

![ej3](imgs/ej3.gif)

Script: [CharacterMovement.cs](scripts/CharacterMovement.cs)

4. Además necesitamos que el sprite se oriente hacia donde camina, podemos hacerlo usando la propiedad Flip en el eje X en función de si se está moviendo hacia la izquierda (movimiento negativo) o hacia la derecha (movimiento positivo).

![ej4](imgs/ej4.gif)

Script: [CharacterMovement.cs](scripts/CharacterMovement.cs)

5. Crear las animaciones del personaje.

![ej5](imgs/ej5.gif)

Script: [CharacterMovement.cs](scripts/CharacterMovement.cs)
