﻿namespace Asteroids.Model
{
    public class EnemiesSimulation : Simulation<Enemy>
    {
        public void Simulate(Enemy enemy)
        {
            PlacedEntity placedEntity = new PlacedEntity(enemy, enemy);

            Simulate(placedEntity);
        }

        public override void Update(float deltaTime)
        {
            foreach (var entity in Entities)
                entity.Entity.Update(deltaTime);
        }
    }
}
