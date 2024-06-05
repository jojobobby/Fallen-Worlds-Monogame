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
        private const int WIDTH = 20;
        private const int HEIGHT = 20;

        public HashSet<StaticObject> StaticObjects;
        public HashSet<BasicObject> BasicObjects;
        public Player Player;
        public Program GameSprite;
        public Square[] Squares;

        public Map(Program gameSprite)
        {
            this.GameSprite = gameSprite;
        }

        public void Initialize()
        {
            this.Squares = new Square[WIDTH * HEIGHT];
            this.Player = new Player(this, GameSprite.Content.Load<Texture2D>("Ship"), new Vector2(100, 100));
            this.StaticObjects = [];
            this.BasicObjects = [];

            InitTiles();
        }

        private void InitTiles()
        {
            for (int x = 0; x < WIDTH; x++)
            {
                for (int y = 0; y < HEIGHT; y++)
                {
                    var square = new Square(this, x, y);
                    //just draw instead of initalize.
                    //Only done this way because we need texture and I havent set up a loadtexture class yet.
                    square.Initialize();
                    

                    this.Squares[x + y * WIDTH] = square;
                }
            }
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

            foreach (var BasicObject in this.BasicObjects)
            {
                BasicObject.Update();
            }

            foreach (var StaticObject in this.StaticObjects)
            {
                StaticObject.Update();
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var Square in Squares)
            {
                Square.Draw(spriteBatch);
            }

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
