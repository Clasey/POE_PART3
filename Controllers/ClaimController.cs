namespace POE_PART3.Controllers
{
    public class ClaimController
    {
        private readonly List<Claim> claims = new List<Claim>();

        public List<Claim> GetClaims()
        {
            return claims;
        }

        public void AddClaim(Claim claim)
        {
            claims.Add(claim);
        }

        public void UpdateClaimStatus(int claimId, string newStatus)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimId == claimId);
            if (claim != null)
                claim.Status = newStatus;
        }
    }
}
