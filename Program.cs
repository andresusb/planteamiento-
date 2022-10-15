#include <PARCIAL#2.h>
void salir();
int menu_profesor();
int menu_profe;
int validacion(int id_profe, int clave);
int validacion(int cod_estudiante);
void entar();
int id_profe;
int menu_estudiante();
int clave;
int i,x,n;
int cod_estudiante;
int registrar();
int arr[12];
int notas();
int consultar();
int tabulacion();
int suma = 0, prom = 0:

struct profesor 
{
    int id_profe;
    int clave;
};
struct profesor p[3]={{98756,123456},{76548,45678},{26547,09876}};

struct estudiantes 
{
    int codigo_estudiante;
    int clave;
    int nota#1
    int nota#2
    int nota#3;
};
struct estudiantes e[3]={{30009845,09876543},{30006574,12345678},{30002356,098123657}};

int main()
{

  while(1)
  (
    int menu 
    printf('Bienvenido colegio casita azul /n');
    printf('N°1.profesor \n N°2.Estudiante \n N°3.salir \n' );
    scanf ('%d', &Inicio)
    switch (Inicio)

    {
        {
            case N°1:
            INGRESO();
            //MenuProfesor();
            break;
        }
        {
            case N°2:
            INGRESO();
            //MenuEstudiante();
        }
        {
            case N°3:
            exit(1);
            break;
        }
        default:
        printf('comando no disponible \n');
    }
void Entrada()
{
    printf('\n Escriba su Usuario \t');
    scanf('%d',&id_profe);
    printf('\n Escriba su contraseña\t');
    scanf('%d',clave);
    a= validacion(id_profe,clave);
}
int validacion(int id_profe, int clave);
{
    for (i=0;i<2;i++)
    {
        if(d[i].usuario==id_profe)
        {
            if(d[i].clave==clave)
            {
                return i;
                break;
            }
            else
            {
                printf('\n clave incorrecta');
                exit(1);
            }
        }
        menu_profe
    }
}
int menu_profe
{
    printf('N°1.Registrarce \n N°2.Consultar \n N°3.Salir \n');
    scanf
    switch (menu_profe)
    {
        case N°1:
        {
            Registrarce();
            Notas();
            break;
        }
        case N°2:
        {
            Consultar();
        }
        case N°3
        {
            Exit(1);
            break;
        }
        default:
        printf('opccion incorrecta \n');
    }
 }

 int Registrarce() {
    printf('\n ingrese el codigo de estudiante \t');
    scanf('%d',&codigo_estudiante);
    x= validar(codigo_estudiante);
        
     for (i=0;i<1,i++)
     {
        if(e[i].usuariodeingreso==codigo_estudiante)
        {
            return i;
            break;
        }
        else
        {
            printf('\n ususario innexistente');
            exit(1);
        }
     }
     notas();
 }

 int notas()
 {
    fror(n=0;n<10;n++)
    {
        printf('ingrese la nota para poder hacer la %d \n',n+1);
        scanf('%d',%arr[n]);
    }
 }

 int menuestudiante()
 {
    printf('N°1. Consultar \n N°2. Promedio notas \n N°3. Salir \n');
    scanf('%i',&menu_estudiante);
    switch (menu_estudiante)

      case N°1:
      {
        Consultar();
        break;
      }
      case N°2;
      {
        promedio notas()
        break
      }
      case N°3:
      {
        salir(1)
        break;
      }

      default:
      printf('opcion no valida \n');

int revizar();

 //printf('sus notas son las siguientes: \n');
 //for (n=0;n<10;n++)
{ 
    printf('%d\n',arr[n]);
}

int Tabulacion()
{
    for (n=0;n<10;n++)
    (suma=suma+n);
    Tabulacion=suma\n;
    printf('su tabulacion de notas es:%.1d\n'tabulacion)
}

 }

}