# Countries SQLite Database

## Description
Contains a simple demonstration of a countries database using SQLite. It includes sample data for several countries with information such as their capitals, main cities, population, continent, and language.

## Technologies Used
- **Database**: SQLite
- **Languages**: C#

## Database Structure
The database consists of a single table named `countries`, where each row represents a country. The table includes the following columns:
- `country_name`: Name of the country.
- `capital`: Capital city of the country.
- `main_cities`: List of main cities in the country.
- `population`: Population of the country.
- `continent`: Continent where the country is located.
- `language`: Official language of the country.

## Sample Data
Here is some sample data for a few countries:
- **United States:**
  - Country Name: United States
  - Capital: Washington, D.C.
  - Main Cities: New York City, Los Angeles, Chicago
  - Population: 331 million
  - Continent: North America
  - Language: English

- **France:**
  - Country Name: France
  - Capital: Paris
  - Main Cities: Marseille, Lyon, Toulouse
  - Population: 67 million
  - Continent: Europe
  - Language: French

- **Brazil:**
  - Country Name: Brazil
  - Capital: Brasília
  - Main Cities: São Paulo, Rio de Janeiro, Salvador
  - Population: 212 million
  - Continent: South America
  - Language: Portuguese

- **China:**
  - Country Name: China
  - Capital: Beijing
  - Main Cities: Shanghai, Guangzhou, Shenzhen
  - Population: 1.4 billion
  - Continent: Asia
  - Language: Chinese (Mandarin)

- **Australia:**
  - Country Name: Australia
  - Capital: Canberra
  - Main Cities: Sydney, Melbourne, Brisbane
  - Population: 25 million
  - Continent: Australia
  - Language: English

## Output

### Table: Countries
| Country Name  | Capital    | Main Cities                   | Population   | Continent      | Language   |
|---------------|------------|-------------------------------|--------------|----------------|------------|
| United States | Washington | New York, Los Angeles, Chicago | 332,000,000  | North America  | English    |
| France        | Paris      | Paris, Marseille, Lyon         | 67,000,000   | Europe         | French     |
| Brazil        | Brasília   | São Paulo, Rio de Janeiro      | 213,000,000  | South America  | Portuguese |
| China         | Beijing    | Shanghai, Beijing, Guangzhou   | 1,441,000,000| Asia           | Chinese    |
| Australia     | Canberra   | Sydney, Melbourne, Brisbane    | 25,400,000   | Australia      | English    |

### After Updating Population for United States
| Country Name  | Capital    | Main Cities                   | Population   | Continent      | Language   |
|---------------|------------|-------------------------------|--------------|----------------|------------|
| United States | Washington | New York, Los Angeles, Chicago | 350,000,000  | North America  | English    |
| France        | Paris      | Paris, Marseille, Lyon         | 67,000,000   | Europe         | French     |
| Brazil        | Brasília   | São Paulo, Rio de Janeiro      | 213,000,000  | South America  | Portuguese |
| China         | Beijing    | Shanghai, Beijing, Guangzhou   | 1,441,000,000| Asia           | Chinese    |

### After Deleting Australia from the Database
| Country Name  | Capital    | Main Cities                   | Population   | Continent      | Language   |
|---------------|------------|-------------------------------|--------------|----------------|------------|
| United States | Washington | New York, Los Angeles, Chicago | 350,000,000  | North America  | English    |
| France        | Paris      | Paris, Marseille, Lyon         | 67,000,000   | Europe         | French     |
| Brazil        | Brasília   | São Paulo, Rio de Janeiro      | 213,000,000  | South America  | Portuguese |
| China         | Beijing    | Shanghai, Beijing, Guangzhou   | 1,441,000,000| Asia           | Chinese    |

## Notes
- This repository demonstrates my learning of a simple SQLite database for managing country information.
- The database can be expanded with more countries and additional details as needed.
- SQLite is a lightweight, self-contained SQL database engine that is easy to use and suitable for small-scale applications.

