#include <CGAL/Exact_predicates_inexact_constructions_kernel.h>
#include <CGAL/Surface_mesh.h>

#include <CGAL/Polygon_mesh_slicer.h>
#include <CGAL/Polygon_mesh_processing/IO/polygon_mesh_io.h>

#include <CGAL/AABB_halfedge_graph_segment_primitive.h>
#include <CGAL/AABB_tree.h>
#include <CGAL/AABB_traits.h>

#include <iostream>
#include <list>
#include <string>
#include <vector>

typedef CGAL::Exact_predicates_inexact_constructions_kernel     k;
typedef CGAL::Surface_mesh<k::Point_3>                          mesh_type;

typedef std::vector<k::Point_3>                                 polyline_type;
typedef std::list<polyline_type>                                polylines;

typedef CGAL::AABB_halfedge_graph_segment_primitive<mesh_type>  hgsp;
typedef CGAL::AABB_traits<k, hgsp>                              aabb_traits;
typedef CGAL::AABB_tree<aabb_traits>                            aabb_tree;

namespace pmp = CGAL::Polygon_mesh_processing;

int main(const int argc, char* argv[])
{
  const std::string filename = (argc > 1) ? argv[1] : CGAL::data_file_path("meshes/eight.off");

  mesh_type mesh;

  if (!pmp::IO::read_polygon_mesh(filename, mesh) || is_empty(mesh) || !is_triangle_mesh(mesh))
  {
    std::cerr << "Invalid input." << std::endl;
    return 1;
  }

  double zmax = 0;
  double zmin = -1;

  for(const auto& point : mesh.points())
  {
    const auto z = point.z();
    zmax = z > zmax ? z : zmax;
    zmin = (zmin < 0) || (z < zmin) ? z : zmin;
  }

  return 0;
}
