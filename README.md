# EjercicioHerencia
Ejercicio 4 Herencia
El enunciado de estos deberes es:
4)
Crearemos una supeclase llamada Electrodomestico con las siguientes características:
•Sus atributos son precio base, color, consumo energético (letras entre AyF) y peso. Indica que se podrán heredar.
•Por defecto, el color sera blanco, el consumo energético sera F, el precioBase es de 100 € y el peso de 5 kg. 
•Los colores disponibles son blanco, negro, rojo, azul y gris. No importa siel
nombre esta en mayúsculas o enminúsculas.
Los constructores que se implementaranserán
  -Un constructor pordefecto.
  -Un constructor con el precio y peso. El resto pordefecto.
  -Un constructor con todos losatributos.
Los métodos que implementaraserán:
•Métodos get de todos losatributos.
•comprobarConsumoEnergetico(char letra): comprueba que la letra es correcta, 
  sino es correcta usara la letra por defecto. Se invocara al crear el objeto y no seravisible.
•comprobarColor(String color): comprueba que el color es correcto, sino lo es usa el color por defecto. 
  Se invocara al crear el objeto y no seravisible.
•precioFinal(): según el consumo energético, aumentara su precio, y según su tamaño, también.

Crearemos una subclase llamada Lavadora con las siguientescaracterísticas:
•Su atributo es carga, ademas de los atributosheredados.
•Por defecto, la carga es de 5 kg. Usa una constante paraello.
Los constructores que se implementaranserán:
  -Un constructor pordefecto.
  -Un constructor con el precio y peso. El resto pordefecto.
  -Un constructor con la carga y el resto de atributos heredados. Recuerda que debes llamar al constructor de la clasepadre.
Los métodos que se implementaraserán:
•Método get decarga.
•precioFinal():, si tiene una carga mayor de 30 kg, aumentara el precio50
€, sino es así no se incrementara el precio. Llama al método padre y añade el código necesario. 
Recuerda que las condiciones que hemos visto en la clase Electrodomestico también deben afectar alprecio.

Crearemos una subclase llamada Television con las siguientescaracterísticas:
•Sus atributos son resolución (en pulgadas) y sintonizador TDT (booleano), ademas de los atributosheredados.
•Por defecto, la resolución sera de 20 pulgadas y el sintonizador serafalse.
Los constructores que se implementaranserán:
  -Un constructor pordefecto.
  -Un constructor con el precio y peso. El resto pordefecto.
  -Un constructor con la resolución, sintonizador TDT y el resto deatributos
  heredados. Recuerda que debes llamar al constructor de la clasepadre.
Los métodos que se implementaraserán:
•Método get de resolución y sintonizadorTDT.
•precioFinal(): si tiene una resolución mayor de 40 pulgadas, se incrementara el precio un 30% 
y si tiene un sintonizador TDT incorporado, aumentara 50 €. Recuerda que las condiciones que hemos
visto en la clase Electrodomestico también deben afectar alprecio.

Ahora crea una clase ejecutable que realice losiguiente:
•Crea un array de Electrodomesticos de 10posiciones.
•Asigna a cada posición un objeto de las clases anteriores con los valores que desees.
•Ahora, recorre este array y ejecuta el métodoprecioFinal().
•Deberás mostrar el precio de cada clase, es decir, el precio de todas las televisiones por un lado, 
el de las lavadoras por otro y la suma de los Electrodomesticos (puedes crear objetos Electrodomestico, 
pero recuerda que Television y Lavadora también son electrodomésticos). Recuerda el uso operador instanceof.
Por ejemplo, si tenemos un Electrodomestico con un precio final de 300, una lavadora de 200 y una televisión 
de 500, el resultado final sera de 1000 (300+200+500) para electrodomésticos, 200 para lavadora y 500 paratelevisión.
