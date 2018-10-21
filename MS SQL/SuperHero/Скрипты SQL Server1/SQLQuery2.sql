use SuperHero

select NameHero, count( Name_superpower) as counts_superpowers from Superpower 
inner join Hero on ID_hero=Hero.ID
group by NameHero
having count( Name_superpower)>2;

select NameHero, count( Name_superpower) as counts_superpowers from Superpower 
inner join Hero on ID_hero=Hero.ID
where skill>5
group by NameHero
having count( Name_superpower)>2
order by count(Name_superpower) desc;
