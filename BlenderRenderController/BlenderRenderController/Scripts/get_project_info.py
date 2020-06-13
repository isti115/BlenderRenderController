import os
import json
import bpy
import re
from bpy import context
from bpy import ops
from bpy import data

blendPath = bpy.context.blend_data.filepath;
projName  = bpy.path.display_name_from_filepath( blendPath );

# get number of Scenes and active scene name
n_data = bpy.data.scenes
a_data = bpy.context.scene

# get values from strings
N_of_Scenes = str(n_data).partition('[')[-1].rpartition(']')[0]
ActiveScene = str(a_data).partition('("')[-1].rpartition('")')[0]

# set infos acording to active Scene
startFrame = bpy.data.scenes[ActiveScene].frame_start
endFrame   = bpy.data.scenes[ActiveScene].frame_end
outputPath = bpy.data.scenes[ActiveScene].render.filepath

# get rendering engine
renderingEngine = bpy.context.scene.render.engine

"""
Error code table:
 0: no errors
-1: output unset, lenth = 0
-2: output invalid, no slashes in path
-3: output is relative, has // at start
"""

# check if relative
rel_chk = outputPath[0:2]

if len(outputPath) == 0:
    errorcode = -1

elif outputPath.count("\\") == 0:
    errorcode = -2

elif rel_chk == "//":
    errorcode = -3

else:
    errorcode = 0

# os.path.isabs(my_path) | true = absolute, false = relative

# get output dir minus file name
altdir = str(outputPath).rpartition('\\')[:-1][0]

#print( "Proj Name: %s\n" % (projName) )
#print( "Start: %s\n" % (startFrame) )
#print( "end: %s\n" % (endFrame) )

data = { 'ProjectName': projName, 'StartFrame': startFrame, 'EndFrame': endFrame, 'OutputDirectory': outputPath,  
        'NumScenes': N_of_Scenes, 'ActiveScene': ActiveScene, 'AltDir': altdir, 'ErrorCode': errorcode,
        'RenderingEngine': renderingEngine };

jsonData = json.dumps(data, indent=4, skipkeys=True, sort_keys=True);


with open('blend_info.json', 'w') as f:
    print(jsonData, file=f)

print(jsonData);

