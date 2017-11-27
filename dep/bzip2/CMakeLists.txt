file(GLOB sources_bzip2 ./*.c)

add_library(bzip2 ${sources_bzip2})

set_target_properties(bzip2 PROPERTIES FOLDER Dependencies)