Copyright (C) 2015  Igor Kotlerman <igor.kotlerman@gmail.com>

LeukocyteGUI_for_oclHashCat is a GUI wrapper and
cracking tasks manager for oclHashcat.

LeukocyteGUI_for_oclHashCat: https://github.com/kotlerman/LeukocyteGUI_for_oclHashCat
oclHashcat homepage:         http://hashcat.net/

Features and instructions:
- .cap to .hccap converter GUI
    - Specify aircrack-ng.exe converter and output directory
    - Add files to convert by using buttons or drag-n-drop them to the cracking list
    - Click convert buttton and see the results (successfully converted files
      will appear in the output folder
- Cracking tasks management
    - Save dictionaries and masks to program's base using Settings form (optional)
    - Add/Modify tasks using TaskEditor
    - Order tasks in TasksManager (main window)
    - Control the cracking process: Start/Pause/Stop craking
    - Tick tasks and activate "Crack all checked" for automatic serial cracking
	- The cracking process is visualy displayed by progress bars
	- Results are displayed in the cracking tasks list and
      popup notification windows (if enabled in the settings)
    - Personalize settings
    - Tasks, masks and dictionaries are saved in binnary format
