using System;

public class Introduction
{
	public Introduction()
	{
		//variaveis

		int numero = 10;
		float nDecimal = 3.5f;
		string palavra = 'Alo';
		bool boleana = true;

		int speed;
		string enemyName;
		float health;


		EnemyWeapon weapon; //acessador de um metodo de outra classe para essa atual

		//listas
		int[] intArray = new int[] { 1, 2, 3 };
		List<int> intList = new List<int>() { 4, 5, 6 };

		//metodo
		void Movement()
		{
            //condicao
            if (speed > 0 && health > 0)
			{

			}
			else
			{

			}
		}

		void Dead()
		{
			if(health <= 0)
			{

			}
		}

		void Attack()
		{
			weapon.damage = 25;
			weapon.Shoot(); //chamada do metodo e sua funcao
		}

        //intList.Add(7);
        //intList.Remove(4);

        foreach (int intNumbers in intArray)
        {

        }

        for (int i = 0; i <= intArray.Lenght; i++)
        {
			int currentNumber = intArray[i];
        }

        for (int i = 0; i <= intList.Count; i++)
        {
            int currentNumber = intList[i];

        }

    }
}

public class EnemyWeapon
{
	//public para tornar a variavel ou o metodo usavel em outra classe
	public float damage;
	public float fireRate;

	public void Shoot()
	{

	}
}
