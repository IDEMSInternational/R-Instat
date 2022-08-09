# Translations folder
This folder contains natural language translations (e.g. from English to French) for the user-displayed text in R-Instat.
The files in the directory are:
- `rInstatTranslations.db`: The SQLite database that contains all the translated text together with their translations. For further details of the creation, usage and structure of this database please see `translations.vb` and https://github.com/lloyddewit/TranslateWinForm.
- `en` folder: JSON files that contain the original English text in a format that can be used by the 'CrowdIn' translation platform.
- `<2-digit language code>` folder: The non-English language equivalent (e.g. 'fr' for French) of each file in the `en` folder.
