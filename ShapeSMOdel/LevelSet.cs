namespace ShapeSMOdel
{
    public class LevelSet
    {
        private int _difficulty;
        private bool _isFinished;
        private Level[] _levels;

        public LevelSet(int difficulty, bool isFinished)
        {
            _difficulty = difficulty;
            _isFinished = isFinished;
            _levels = [];
        }



        public void NextLevel(string[] themes)
        {
            if (_isFinished || _levels.Length >= 5)
            {
                return;
            }

            SelectableShape[] selectableShapes = [];
            Shape[] tangledShapes = [];



            switch (_difficulty)
            {
                case 1:

                    _levels.Append(new Level());
                    break;
                default:
                    break;
            }
        }
    }
}
