namespace BasketballTeam.Common;

public static class EntityValidations
{
    // Register validations and Login validations
    public const int EMAIL_MIN_LENGTH = 5;
    public const int EMAIL_MAX_LENGTH = 50;

    public const int USERNAME_MIN_LENGTH = 5;
    public const int USERNAME_MAX_LENGTH = 50;

    public const int PASSWORD_MIN_LENGTH = 6;
    public const int PASSWORD_MAX_LENGTH = 50; 

    public const int CONFIRM_PASSWORD_MIN_LENGTH = 6;
    public const int CONFIRM_PASSWORD_MAX_LENGTH = 50;

    // Coach validations
    public const int FIRSTNAME_MIN_LENGTH = 2;
    public const int FIRSTNAME_MAX_LENGTH = 50;

    public const int LASTNAME_MIN_LENGTH = 2;
    public const int LASTNAME_MAX_LENGTH = 50;

    public const int NATIONALITY_MIN_LENGTH = 7; // Finnish is the shortest
    public const int NATIONALITY_MAX_LENGTH = 27; // Saint-Pierrais et Miquelonnais is longest

    // Player validations  
    public const int NUMBER_MIN_VALUE = 1;
    public const int NUMBER_MAX_VALUE = 99;

    public const int AGE_MIN_VALUE = 18;
    public const int AGE_MAX_VALUE = 45;

    // Team validations
    public const int TEAM_NAME_MIN_LENGTH = 1;
    public const int TEAM_NAME_MAX_LENGTH = 80;
    
    public const int TEAM_LOCATION_MIN_LENGTH = 1;
    public const int TEAM_LOCATION_MAX_LENGTH = 58;

    // Tournament validations
    public const int TOURNAMENT_NAME_MIN_LENGTH = 3;// 3x3
    public const int TOURNAMENT_NAME_MAX_LENGTH = 80;

    public const int TOURNAMENT_LOCATION_MIN_LENGTH = 1;
    public const int TOURNAMENT_LOCATION_MAX_LENGTH = 58;

    public const int TOURNAMENT_DESCRIPTION_MIN_LENGTH = 10;
    public const int TOURNAMENT_DESCRIPTION_MAX_LENGTH = 1000;
}