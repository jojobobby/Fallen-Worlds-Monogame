using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Entry
{
    public partial class Map
    {
        public HashSet<StaticObject> StaticObjects;
        public HashSet<BasicObject> BasicObjects;
        public Player Player;
        public GameSprite GameSprite;

        public Map(GameSprite gameSprite)
        {
            this.GameSprite = gameSprite;
        }

        public void Initialize()
        {
            this.Player = new Player(this, GameSprite.Content.Load<Texture2D>("Untitled"), new Vector2(100, 100));
            this.StaticObjects = [];
            this.BasicObjects = [];
        }

        public void AddBasicObject(BasicObject basicObject)
        {
            switch (basicObject)
            {
                case StaticObject:
                    this.StaticObjects.Add(basicObject as StaticObject);
                    break;
                default:
                    this.BasicObjects.Add(basicObject);
                    break;
            }

            basicObject.Initialize();
        }

        public void Update()
        {
            this.Player.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            this.Player.Draw(spriteBatch);

            foreach ( var BasicObject in this.BasicObjects )
            {
                BasicObject.Draw(spriteBatch);
            }

            foreach (var StaticObject in this.StaticObjects)
            {
                StaticObject.Draw(spriteBatch);
            }
        } 
    }
}
