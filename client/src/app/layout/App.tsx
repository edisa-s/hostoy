import { Box, Container, CssBaseline } from "@mui/material";
import { Outlet, useLocation, ScrollRestoration } from "react-router";
import NavBar from "./NavBar";
import HomePage from "../../features/activities/dashboard/home/HomePage";

function App() {
  const location = useLocation();
  return (
    <Box sx={{ bgcolor: "#eeeeee", minHeight: "100vh" }}>
      <ScrollRestoration />
      <CssBaseline />
      {location.pathname === "/" ? (
        <HomePage />
      ) : (
        <>
          <NavBar />
          <Container maxWidth="xl" sx={{ mt: 14 }}>
            <Outlet />
          </Container>
        </>
      )}
    </Box>
  );
}
export default App;
