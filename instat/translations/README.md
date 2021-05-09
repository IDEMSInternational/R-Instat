# Translations folder
This folder contains natural language translations (e.g. from English to French) for the user-displayed text in R-Instat.
The files in the directory are:
- `rInstatTranslations.db`: The SQLite database that contains all the translated text together with their translations. For further details of the creation, usage and structure of this database please see `translations.vb` and https://github.com/lloyddewit/TranslateWinForm.
- `translationsManuallyEntered`: A list of English text that needs to be translated, which is not identified by any of the automated functions or scripts that generate the rest of the database. This file is stored here in case the `rInstatTranslations.db` database ever needs to be generated again from scratch.
- `en` folder: JSON files that contain the original English text in a format that can be used by the 'CrowdIn' translation platform.
- `fr` folder: The French equivalent of each file in the `en` folder.
