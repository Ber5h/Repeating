using System;

class Archer
{
	private string name;
	private int shots;
	private int totalAttack;
	private int defence;
	private int totalLife;
	private int life;
	public Archer()
	{
		name = "Полное прекращение работы телеграмм в России";
		shots = 10; //зачем они вообще нужны
		totalAttack = 10;
		defence = 7;
		totalLife = 20;
		life = 20;
	}
	public Archer (string name)
    {
		this.name = name;
		shots = 10;
		totalAttack = 10;
		defence = 7;
		totalLife = 20;
		life = 20;
    }
	public Archer(string name, int shots, int totalAttack, int defence, int Totallife)
	{
		this.name = name;
		this.shots = shots;
		this.totalAttack = totalAttack;
		this.defence = defence;
		this.totalLife = Totallife;
		this.life = Totallife;
	}
	int LifePersent
	{
		get
		{
			return life / totalLife * 100;
		}
	}
	int Attack
	{
		get
		{
			totalAttack* LifePercent/ 100;
		}
	}
	bool Alive
	{
		get
		{
			return (life > 0);
		}
	}
	private void Damage(int wound)
	{
		life = life - wound;
	}
	public void Shut(Archer opponent)
	{
		try
		{
			message_shut.Text = $"{this.Name} выстрелил в {opponent.Name}";
			opponent.Damage(this.Attack - opponent.defence);
			this.shots--;
		}
		catch (this.shots <= 0)
	    {
			throw new Exception("У игрока не осталось стрел");
		}
		}
	public string Name
	{
		get
		{
			return name;
		}
	}
	public int Shots
	{
		get
		{
			return shots;
		}
		set
		{
			try
			{
				shots = value;
			}
			catch (value <= 0)
				{
				throw new Exception("Значение не может быть меньше нуля");
			}
			}
		}
		public int TotalAttack
	{
		get
		{
			return totalAttack;
		}
		set
		{
			try
			{
				totalAttack = value;
			}
			catch (value <= 0)
				{
				throw new Exception("Значение не может быть меньше нуля");
			}
			}
		}
		public int Defence
	{
		get
		{
			return defence;
		}
		set
		{
			try
			{
				defence = value;
			}
			catch (value <= 0)
				{
				throw new Exception("Значение не может быть меньше нуля");
			}
			}
		}
		public int Totallife
	{
		get
		{
			return totalLife;
		}
		set
		{
			try
			{
				totalLife = value;
			}
			catch (value <= 0)
				{
				throw new Exception("Значение не может быть меньше нуля");
			}
			}
		}
		public int Life
	{
		get
		{ return life; }
	}

}
