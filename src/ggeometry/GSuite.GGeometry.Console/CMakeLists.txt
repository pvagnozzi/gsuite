cmake_minimum_required(VERSION 3.21)    # CMake version check

project(ggeometry)                      # Create project "ggeometry"
set(CMAKE_CXX_STANDARD 20)              # Enable c++20 standard
set(CMAKE_CXX_STANDARD_REQUIRED ON)     
set(CMAKE_CXX_EXTENSIONS ON)

# Toolchain 
set(CMAKE_TOOLCHAIN_FILE "c:/tools/vcpkg/scripts/buildsystems/vcpkg.cmake")

# Output directory
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin)

if(CMAKE_CXX_FLAGS MATCHES "/W[0-4]")
	string(REGEX REPLACE "/W[0-4]" "/W4" CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS}")
endif()

set(THREADS_PREFER_PTHREAD_FLAG ON)

set(Boost_USE_STATIC_LIBS        ON)
set(Boost_USE_DEBUG_LIBS        OFF)
set(Boost_USE_RELEASE_LIBS       ON)
set(Boost_USE_MULTITHREADED      ON)
set(Boost_USE_STATIC_RUNTIME    OFF)

set(BOOST_ROOT "${_VCPKG_INSTALLED_DIR}/${VCPKG_TARGET_TRIPLET}")
set(BOOST_INCLUDE_DIR "${_VCPKG_INSTALLED_DIR}/${VCPKG_TARGET_TRIPLET}/include")
set(BOOST_LIBRARY_DIR "${_VCPKG_INSTALLED_DIR}/${VCPKG_TARGET_TRIPLET}/lib")

find_path(BOOST_INCLUDE_DIR boost)
find_package(Threads REQUIRED)
find_package(CGAL CONFIG REQUIRED)
include_directories(${BOOST_INCLUDE_DIR})

add_executable(ggeometry "main.cpp")
target_link_libraries(ggeometry ${BOOST_LIBRARIES})
target_link_libraries(ggeometry CGAL::CGAL)
target_link_libraries(ggeometry Threads::Threads)

if (CMAKE_CXX_COMPILER_ID MATCHES "Clang|AppleClang|GNU")
    target_compile_options(ggeometry PRIVATE -Wall -Wextra -Wunreachable-code -Wpedantic)
endif()
if (CMAKE_CXX_COMPILER_ID MATCHES "Clang")
    target_compile_options(ggeometry PRIVATE -Wweak-vtables -Wexit-time-destructors -Wglobal-constructors -Wmissing-noreturn )
endif()

if (CMAKE_CXX_COMPILER_ID MATCHES "MSVC")
    target_compile_options(ggeometry PRIVATE /W4 /w44265 /w44061 /w44062 )
endif()
