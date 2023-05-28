# Torre de Control de Tráfico Aéreo (Aereal Tower Traffic Control)
Ejercicio de C#

![lesluthiers](https://github.com/gabi-devel/Torre_de_control/assets/82919745/f6e7bcee-4d8d-4245-80eb-4aa47cc711d3)
https://mega.nz/file/GQ52GB6T#s3zLm7F2M9IoKx9HTaTlwDNSDVB0Nof2TlT96RSpNR0

Simular el funcionamiento de una torre de control aeroportuaria durante un turno a través de dos objetos (cola de arribo y cola de despegue)

Los datos de entrada estarán formados por el número de vuelo (un número entre 1 y 9999), la matrícula del avión (formada por tres letras mayúsculas), la hora en formato militar (ej: 1800) y la operación (A: arribo o D: despegue) 

El final de las operaciones del turno se identifica con un número de vuelo negativo.

Los objetos cola de arribo y cola de despegue irán cargando estos datos, teniendo en cuenta que los números de vuelo menores que 1000 (sólo para aviones que aterrizarán) deben tener prioridad absoluta para aterrizar y no entran en cola de arribo.

Los aterrizajes tienen prioridad sobre los despegues, por lo que para autorizar un despegue, la torre no debe tener en espera ningún arribo (para este control, se considerarán los horarios de entrada en cola)

Se debe producir como salida una lista con la información cronológica de las operaciones del turno en la torre de control.

Ejemplo de lista de salida:

1234 - OFP - 1800 - A - Aterrizaje normal

0421 - LPV - 1815 - A - Aterrizaje prioritario

2003 - FOP - 1810 - A - Aterrizaje normal

2120 - VPO - 1805 - D - Despegue normal

1022 - YTP - 1812 - A - Aterrizaje normal
