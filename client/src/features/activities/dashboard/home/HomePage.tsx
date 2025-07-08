import { Group } from "@mui/icons-material";
import { Box, Button, Paper, Typography } from "@mui/material";
import { Link } from "react-router-dom";

export default function HomePage() {
  return (
    <Paper
      sx={{
        color: "white",
        display: "flex",
        flexDirection: "column",
        gap: 6,
        alignItems: "center",
        alignContent: "center",
        justifyContent: "center",
        height: "100vh",
        backgroundImage:
          "linear-gradient(135deg, #9c27b0 0%, #e040fb 69%, #f48fb1 89%)",
        position: "relative",
      }}
    >
      <Box
        sx={{
          display: "flex",
          alignItems: "center",
          alignContent: "center",
          color: "white",
          gap: 3,
        }}
      >
        <Group sx={{ height: 110, width: 110 }} />
        <Typography variant="h1">Estto</Typography>
      </Box>
      <Typography variant="h2">Welcome</Typography>
      <Button
        component={Link}
        to="/activities"
        size="large"
        variant="contained"
        color="secondary"
        sx={{ height: 80, borderRadius: 4, fontSize: "1.5rem" }}
      >
        Take me to Estto
      </Button>
    </Paper>
  );
}
