namespace Hockey.Data
{
    /// <summary>
    /// An instance of this class will hold all the information about a hockey player.
    /// </summary>
    public class HockeyPlayer
    {
        // Data fields
        private string _birthPlace;
        private DateOnly _dateOfBirth;
        private string _firstName;
        private int _heightInInches;
        private string _lastName;
        private int _weightInPounds;
        //private Position _position; // this is now a property
        //private Shot _shot;

        // Properties
        public string BirthPlace
        {
            get
            {
                return _birthPlace;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth place cannot be null or empty.");
                }

                _birthPlace = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }

                _lastName = value;
            }
        }

        public int HeightInInches
        {
            get
            {
                return _heightInInches;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be postive.");
                }

                _heightInInches = value;
            }
        }

        public int WeightInPounds
        {
            get
            {
                return _weightInPounds;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be postive.");
                }

                _weightInPounds = value;
            }
        }

        public DateOnly DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Date of birth cannot be null.");
                }

                _dateOfBirth = value;
            }
        }

        public Position Position
        {
            get; set;
        }

        public Shot Shot
        {
            get; set;
        }

        // Default Constructor
        public HockeyPlayer()
        {
            _birthPlace = string.Empty;
            _dateOfBirth = new DateOnly();
            _firstName = string.Empty;
            _heightInInches = 0;
            _lastName = string.Empty;
            _weightInPounds = 0;
            Position = Position.Center;
            Shot = Shot.Left;
        }

        // Greedy Constructor
        public HockeyPlayer(string birthPlace, DateOnly dateOfBirth, string firstName, int heightInInches, string lastName, int weightInPounds, Position position = Position.Center, Shot shot = Shot.Left)
        {
            BirthPlace = birthPlace;
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            HeightInInches = heightInInches;
            LastName = lastName;
            WeightInPounds = weightInPounds;
            Position = position;
            Shot = shot;
        }

    }
}